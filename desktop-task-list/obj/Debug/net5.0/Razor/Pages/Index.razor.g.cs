#pragma checksum "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0daf81c98f06ae3836bbd3995f42ef283f05bfc6"
// <auto-generated/>
#pragma warning disable 1591
namespace desktop_task_list.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using desktop_task_list;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\_Imports.razor"
using desktop_task_list.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "todo-container");
            __builder.AddMarkupContent(2, "<h1>desktop-task-list!</h1>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "todo-input");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
                                  todoInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todoInput = __value, todoInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
                          AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
     for (var i = 0; i < todos.Count; i++ ){

        var index = i;
        var todo = todos[i];


#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "todo-item");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "todo-item__text");
            __builder.AddContent(17, 
#nullable restore
#line 16 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
                                          todo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "todo-item__close");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
                                                      () => Remove(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "×");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Aram\Documents\UMKC\GitHub\desktop_task_list\desktop-task-list\Pages\Index.razor"
 
    public string todoInput {get; set;}
    public List<string> todos = new List<string>();

    public void AddTodo()
    {
        todos.Add(todoInput);
        todoInput="";
    }

    public void Remove(int index)
    {
        todos.RemoveAt(index);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
