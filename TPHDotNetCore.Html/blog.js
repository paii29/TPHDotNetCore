const tblBlog = "blogs";

// createBlog()
// updateBlog("2cc03e03-4e0c-404b-a4fb-4efaa923b38b", "new data","new data","new data")
deleteBlog("2cc03e03-4e0c-404b-a4fb-4efaa923b38b", "new data","new data","new data")

function readBlog()
{
  localStorage.getItem();
}

function createBlog(){
  const blogs = localStorage.getItem(tblBlog);

  let lst = [];
  if(blogs !== null)
  {
    lst = JSON.parse(blogs);
  }

  const requestModel = {
    id: uuidv4(),
    title: "Test Title",
    author: "Test Author",
    content: "Test Content"
  };

  lst.push(requestModel);

  const jsonBlog = JSON.stringify(lst);
  localStorage.setItem(tblBlog, jsonBlog);
}

function updateBlog(id, title, author, content)
{
  const blogs = localStorage.getItem(tblBlog);
  console.log(blogs);

  let lst = [];
  if(blogs !== null)
  {
    lst = JSON.parse(blogs);
  }

  const items = lst.filter(x => x.id === id);
  // console.log(items);
  console.log(items.length);
  if(items.length == 0){
    console.log("No Data Found");
    return;
  }
  
  const item = items[0];
  console.log(item);

  item.title = title;
  item.author = author;
  item.content = content;

  const index = lst.findIndex(x => x.id === id);
  console.log(index)
  lst[index] = item;

  const jsonBlog = JSON.stringify(lst);
  localStorage.setItem(tblBlog, jsonBlog);

  console.log(lst[index]);
}

function deleteBlog(id)
{
  const blogs = localStorage.getItem(tblBlog);
  console.log(blogs);

  let lst = [];
  if(blogs !== null)
  {
    lst = JSON.parse(blogs);
  }

const items = lst.filter(x => x.id === id);
  if(items.length == 0){
    console.log("No Data Found");
    return;
  }
  
  // console.log(items.length);
  // if(items.length == 0){
  //   console.log("No Data Found");
  //   return;
  // }

  lst = lst.filter(x => x.id !== id);
  const jsonBlog = JSON.stringify(lst);
  localStorage.setItem(tblBlog, jsonBlog);

  console.log(tblBlog.length);
  console.log(tblBlog);
}

function uuidv4() {
  return "10000000-1000-4000-8000-100000000000".replace(/[018]/g, c =>
    (+c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> +c / 4).toString(16)
  );
}

