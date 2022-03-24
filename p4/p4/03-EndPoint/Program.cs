
//StoryBook st = (StoryBook) DataStore.books[0];
//st.GetInfo();

LibraryRepository lb = new();
var storyBooks = lb.GetStoryBooks();
