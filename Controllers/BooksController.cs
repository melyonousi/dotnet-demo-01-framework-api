using dotnet_demo_framework_api_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dotnet_demo_framework_api_04.Controllers
{
    public class BooksController : ApiController
    {
        // Get Primitive parametrs (iny, string...etc)
        //public string GetBook(string title, int numberOfPages)
        //{
        //    return string.Format("Title = {0}, Number of pages = {1}", title, numberOfPages);
        //}

        // Post Primitive parametrs (iny, string...etc)
        public string PostBook(string title, int numberOfPages)
        {
            return string.Format("Title = {0}, Number of pages = {1}", title, numberOfPages);
        }

        // Get Complex Parameters
        [HttpGet]
        public HttpResponseMessage GetBook(Book book)
        {
            if (ModelState.IsValid)
                return new HttpResponseMessage(HttpStatusCode.OK);
            else
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // Post Complex Parameters
        public HttpResponseMessage PostBook(Book book)
        {
            if (ModelState.IsValid)
                return new HttpResponseMessage(HttpStatusCode.OK);
            else
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // Get Complex and Primitive Parameters
        //public string GetBook(Book book, [FromBody] string author)
        //{
        //    return string.Format("Title = {0}, Number of pages = {1}, author = {2}", book.Title, book.NumberOfPages, author);
        //}
    }
}