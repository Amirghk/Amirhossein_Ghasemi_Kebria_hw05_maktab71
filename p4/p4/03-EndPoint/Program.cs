using Newtonsoft.Json;

// json convert settings to ot be stuck in infinite loop
JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    Formatting = Newtonsoft.Json.Formatting.Indented,
    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
};

LibraryRepository lb = new();
var storyBooks = lb.GetStoryBooks();

// sign up members
// log in as members
// borrow books 
// give back books and show the penalty if any
// sign up librarians 
// add writers
// add books and a choice of writers and genres
