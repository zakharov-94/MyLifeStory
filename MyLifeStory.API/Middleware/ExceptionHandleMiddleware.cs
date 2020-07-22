using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyLifeStory.API.Middleware
{
    public class ExceptionHandleMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandleMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (ValidationException ex)
            {
                await HandleException(context, HttpStatusCode.BadRequest, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                await HandleException(context, HttpStatusCode.Unauthorized, ex);
            }
            catch (ApplicationException ex)
            {
                await HandleException(context, HttpStatusCode.BadRequest, ex);
            }
            catch(Exception ex)
            {
                //Log information
                await HandleException(context, HttpStatusCode.InternalServerError, ex);
            }
        }

        private async Task HandleException(HttpContext context, HttpStatusCode statusCode, Exception exception)
        {
            context.Response.Clear();
            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(exception.Message);
        }
    }
}
