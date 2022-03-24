using Newtonsoft.Json;

// json convert settings to ot be stuck in infinite loop
JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    Formatting = Newtonsoft.Json.Formatting.Indented,
    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
};

LibraryRepository lb = new();
var storyBooks = lb.GetStoryBooks();
