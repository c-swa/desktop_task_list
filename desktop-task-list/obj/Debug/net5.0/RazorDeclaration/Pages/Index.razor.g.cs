// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace desktop_task_list.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using desktop_task_list;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using desktop_task_list.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
using BlazorTodoApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "c:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
 
    public string todoInput {get; set; }
    public List<Todo> todos = new List<Todo>();

    public void AddTodo()
    {
        var todo = new Todo();
        todo.Title = todoInput;
        todos.Add(todo);
        todoInput = "";
    }

    public void RemoveTodo(int index)
    {
        todos.RemoveAt(index); 
    }
    public void MarkAsComplete(Todo todo)
    {
        todo.IsComplete = !todo.IsComplete;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
