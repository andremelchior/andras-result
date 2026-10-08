using System;
using System.Collections.Generic;
using System.Text;

namespace Andras.Result.Errors
{
    public sealed class Error
    {
        public Error(
            string Code,
            string Message,
            ErrorType Type,
            IReadOnlyCollection<string>? Details = null)
        {
        }

        public static Error Validation(
            string code,
            string message,
            IReadOnlyCollection<string>? details = null)
        {
            return new Error(
                code,
                message,
                ErrorType.Validation,
                details
            );
        }

        public static Error Unauthorized(
            string code,
            string message)
        {
            return new Error(
                code,
                message,
                ErrorType.Unauthorized
            );
        }

        public static Error Forbidden(
            string code,
            string message)
        {
            return new Error(
                code,
                message,
                ErrorType.Forbidden
            );
        }

        public static Error NotFound(
            string code,
            string message)
        {
            return new Error(
                code,
                message,
                ErrorType.NotFound
            );
        }

        public static Error Conflict(
            string code,
            string message)
        {
            return new Error(
                code,
                message,
                ErrorType.Conflict
            );
        }

        public static Error Failure(
            string code,
            string message)
        {
            return new Error(
                code,
                message,
                ErrorType.Failure
            );
        }
    }
}
