# Q & A: [Eleven Fifty Academy](https://elevenfifty.org/)
## What would you put in version 2.0?

I have big plans for 2.0! I'd like to add:

  - **User Permissions Management** to allow admins to allow general users to access certain views or features, but not others.
  - A complete **ChangeLog** feature for 100% accountability of records modifications.
  - Something called a **Unit Manning Report**, or **UMR**. This is a document the Army uses to visually represent the role assignments of each servicemember, as well as the servicemembers' qualifications in things like medical training, marksmanship, and schools like Ranger or Air Assault.
  - Built-in **Sorting & Filtering** in the *Record/Index* view. This will require at minimum JavaScript, and maybe more stuff I don't know yet. But I'll be learning JavaScript next, plus lots of other things, so these features will be added to the next version!

I'm sure there are lots of other features I haven't had time to think of yet, too.

---
## Do you feel you prepared enough, or would you do more on your next project?

I think I was prepared enough, within the limitations of my knowledge at the beginning of the project.

I didn't know what a View Model was when I started this project, but I came up with the idea for it on my own and only later found out it was a well-known technique for pushing specific sets of data to the View. So once I understood how it was *supposed* to work, I was able to refine my own implementation.

I didn't know anything about `ActionLink` or `UrlHelper` when I started, but I had to learn in order to make my project work the way I'd visualized. In the process, I got a better handle on how polymorphism works with multiple overloads affecting method signatures.

So I think yes, I was prepared, because I had a vision in my head that I laid out in planning documents, despite not understanding what it would take to make the vision a reality. And I kept learning throughout the process in order to get it to work the way I wanted.

---
## What was the coolest functionality you got to work in your opinion?

Okay, I'm pretty excited about this question.  I just got a feature working at the last minute that, while seemingly small, took a lot of effort.

If we open a detailed view of a record, you'll notice that at the bottom of the view is a section that displays information about the creation of the record, and information about the most recent time someone has edited the record. This is a very important feature, because accountability is key when dealing with Human Resources records. If a user makes a change, like promoting the servicemember from E4 to E5, for example, it's important for others to know who made this change.

In this version of the project, this is limited to the most recent modification; future versions will incorporate a complete changelog, but that wasn't feasible given the scope and time alloted for this assignment. I think I've figured out how to implement it now, but I had no idea how it might work when I designed the project at the beginning.

So anyway, until *very* recently this feature only drew from the `ModifiedUtc` property of the Personnel class. This is because the Record models are View Models - they don't exist at the data layer, but instead draw from the data held in properties by the four primary classes. Because each of these four main classes contains a ModifiedUtc property (which is a nullable `DateTimeOffset` type), I basically boxed myself into a corner and had to pick which primary class this feature would draw from. So initially, that was the Personnel class.

But at the last minute, I decided to take another look at this feature. I needed to grab the value of the `ModifiedUtc` property in each main class, associate that with the `ModifiedByUsername` property of each class respectively, and pass those values into a list of some type that would hold them as Key-Value Pairs and then evaluate:

  1. Whether any of the `DateTimeOffset?` values held `null`
  2. Which of the `DateTimeOffset?` values that *weren't* `null`, were the greatest value in the list

I settled on using a `Dictionary` to hold these Key-Value Pairs, but I still had to figure out the logic.

After calling the context I needed to grab the requisite values, I started with a basic conditional:

```c#
var ctx = new ApplicationDbContext();
        IDictionary<string, DateTimeOffset?> versionDictionary = new Dictionary<string, DateTimeOffset?>();

if (ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedUtc.HasValue)
        {
        versionDictionary.Add((ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedByUserName, ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedUtc);
        };

if (ctx.ContactDbSet.Find(Model.ContactId).ModifiedUtc.HasValue)
        {
            versionDictionary.Add((ctx.ContactDbSet.Find(Model.ContactId).ModifiedByUserName, ctx.ContactDbSet.Find(Model.ContactId).ModifiedUtc);
        };

if (ctx.HousingDbSet.Find(Model.HousingId).ModifiedUtc.HasValue)
        {
            versionDictionary.Add((ctx.HousingDbSet.Find(Model.HousingId).ModifiedByUserName, ctx.HousingDbSet.Find(Model.HousingId).ModifiedUtc);
        };

if (ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedUtc.HasValue)
        {
            versionDictionary.Add((ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedByUserName, ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedUtc);
        }
```
Then, I evaluated which of these non-null values was greatest:

```c#
var version = versionDictionary.Max();
```
And instantiated some variables based on that evaluation:
```c#
  var recentModUser = version.Key;
  var recentModDate = version.Value;
```
Wait, that's not too hard, right? Well, if it had worked that way, I wouldn't be bringing it up.

Instead of working as I'd hoped, the first edit I made to test it threw an exception:
```c#
[An item with the same key has already been added.]
```
Doh! As soon as I saw that, it made sense; I'd made the key `ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedByUserName`, which would naturally be the same if a single user had made the most recent edits on two sections or more. So after some trial and error, I altered my conditional to add  `Guid.NewGuid().ToString()` to the end of my Dictionary Keys:
```c#
if (ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedUtc.HasValue)
  {
    versionDictionary.Add((ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedUtc);
  };

if (ctx.ContactDbSet.Find(Model.ContactId).ModifiedUtc.HasValue)
  {
    versionDictionary.Add((ctx.ContactDbSet.Find(Model.ContactId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.ContactDbSet.Find(Model.ContactId).ModifiedUtc);
  }

if (ctx.HousingDbSet.Find(Model.HousingId).ModifiedUtc.HasValue)
  {
      versionDictionary.Add((ctx.HousingDbSet.Find(Model.HousingId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.HousingDbSet.Find(Model.HousingId).ModifiedUtc);
  }

if (ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedUtc.HasValue)
  {
    versionDictionary.Add((ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedUtc);
  }
```
Which meant I also needed to get rid of the extra `Guid` before I passed the value of `recentModUser` to the view. Thankfully, a `Guid` is standardized at 36 characters, so this part was easy:

```c#
var recentModUser = version.Key.Substring(0, version.Key.Length - 36);
```
Cool, I thought. This should work.

Nope! I started getting an error I'd never seen and didn't understand:

```c#
[At least one object must implement IComparable.]
```

Much research and much more trial and error later, I finally understood `IComparable` a tiny, tiny fraction - which was just enough to cross my fingers, reconfigure my variables a bit, and change

```c#
var version = versionDictionary.Max();
```
to

```c#
var user = versionDictionary.Max(e => e.Key).Substring(0, versionDictionary.Max(e => e.Key).Length - 36);
var date = versionDictionary.Max(e => e.Value);

```
This solved my issue, and enabled me to display the `ModifiedUtc` & `ModifiedByUsername` values associated with the most recent changes made to the record, regardless of which class contained the modified values.

Of course, a little while later, I ran into another issue while testing. When I created a brand new set of records and then navigated to a detailed view of the record set, I got the infamous NullReferenceException:

```c#
[Object reference not set to an instance of an object]
```

Uh-oh. This exception was thrown on the definition of my `user` variable, which I'd thought was just fine. But it wasn't fine, because in the event every `DateTimeOffset?` added to the `versionDictionary` held a value of `null`, this exception would be thrown. So I needed a way to check if there are *any* values other than `null` in the `versionDictionary` before deciding what to return. I solved this with a ternary operator on my `user` variable:

```c#
var user = versionDictionary.Any() ? versionDictionary.Max(e => e.Key).Substring(0, versionDictionary.Max(e => e.Key).Length - 36) : "" ;
```
Cool, fixed.  But wait...see where this is going?

Turns out, this definition of `user` was fundamentally flawed from the outset. It actually returns whichever `Key` in the `Dictionary` holds the maximum value, rather than returning the `Key` that *matches* the maximum-value `Value` (the corresponding `DateTimeOffset?`). So once I realized that, I actually had to wipe out my previous definition for `user` and do something more like:

```c#
var user = versionDictionary.Where(e => e.Value == date).Select(e => e.Key.Substring(0, versionDictionary.Max(m => m.Key).Length - 36));
```
This is ugly, but it works. It's ugly because what this actually does is measure the length of my selected `Key` based on the length of the maximum-value `Key` in the `Dictionary`, and then subtract 36 characters from my selection ***based on this other*** **`Key`**. But it works because each Model's `ModifiedByUsername` property returned from the `ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedByUserName` instruction adds exactly 36 characters to the end of the original `ModifiedByUserName` property before adding it to the `versionDictionary`, and then subtracts those characters once it's been selected but before returning the remaining value to `user`.  And I'm not sure how else to write this at the moment, because the `Key` I'm actually selecting gets converted to Type `IEnumerable` during the comparison and selection phase, which means it won't take the `.Length()` extension.

If it's ugly but it works, it's pretty enough.

And that, thankfully, was the last bit I had to fix before I had a working product again.  So the code for this simple little footer section ended up looking like this, inside the Razor block:

```c#
var ctx = new ApplicationDbContext();
IDictionary<string, DateTimeOffset?> versionDictionary = new Dictionary<string, DateTimeOffset?>();

if (ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedUtc.HasValue)
  {
            versionDictionary.Add((ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.PersonnelDbSet.Find(Model.PersonnelId).ModifiedUtc);
  };

if (ctx.ContactDbSet.Find(Model.ContactId).ModifiedUtc.HasValue)
  {
      versionDictionary.Add((ctx.ContactDbSet.Find(Model.ContactId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.ContactDbSet.Find(Model.ContactId).ModifiedUtc);
  }

if (ctx.HousingDbSet.Find(Model.HousingId).ModifiedUtc.HasValue)
  {
      versionDictionary.Add((ctx.HousingDbSet.Find(Model.HousingId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.HousingDbSet.Find(Model.HousingId).ModifiedUtc);
  }

if (ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedUtc.HasValue)
  {
      versionDictionary.Add((ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedByUserName + Guid.NewGuid().ToString()), ctx.UnitInfoDbSet.Find(Model.UnitInfoId).ModifiedUtc);
  }

var user = versionDictionary.Any() ? versionDictionary.Max(e => e.Key).Substring(0, versionDictionary.Max(e => e.Key).Length - 36) : ""
var date = versionDictionary.Max(e => e.Value);

string created = Model.CreatedUtc.ToString("MM/dd/yyyy, HH:mm:ss");
string modified = date.HasValue ? date.Value.ToString("MM/dd/yyyy, HH:mm:ss") : "";
```
And outside the Razor block:
```html
<div class="row">
    <div class="col-md">
        <span class="small">
            @Html.DisplayNameFor(model => model.CreatedByUserName)
            :
            @Html.DisplayFor(model => model.CreatedByUserName)
            <br />
            @Html.DisplayNameFor(model => model.CreatedUtc)
            :
            @Html.DisplayFor(model => created)
        </span>
    </div>
    <div class="col-md">
        <span class="small">
            @Html.DisplayNameFor(model => model.ModifiedByUserName)
            :
            @Html.DisplayFor(model => user)
            <br />
            @Html.DisplayNameFor(model => model.ModifiedUtc)
            :
            @Html.DisplayFor(model => modified)
        </span>
    </div>
</div>
```
Like I said, this took me a while to figure out, and I'm excited that I got it working!

---
## What was the biggest challenge to overcome during this project?

Honestly, just my own lack of knowledge & experience. Which is easy to overcome as long as you keep in mind, any circumstance is no more and no less than what you **MAKE** of it:

- ### **M**otivation
  - within your control
  - a mental game
- ### **A**ptitude
  - partially within your control, can be increased
  - an environmental game
- ### **K**nowledge
  - you have a starting point from which to proceed
  - a mental game
- ### **E**xperience
  - you have a starting point from which to proceed
  - an environmental game

Sue me, I like acronyms. But I came up with this one several years back to make a specific point: 

It takes all these things to excel within your circumstances, and each item is related: the more motivated you are to pursue something, the more aptitude you'll develop; the greater your knowledge grows, the better you'll be able to manipulate your environment to pursue greater experience.

In closing, this was a challenging project, which means it was a fun project! I'm super excited to keep learning. Thanks for your time.