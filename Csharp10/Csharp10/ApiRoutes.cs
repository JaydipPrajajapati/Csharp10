using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10
{
    public static class ApiRoutes
    {
        private const string ApiBase = "/api";

        public static class Library
        {
            private const string Base = ApiBase + "/library";

            public const string GetById = $"{Base}/{{id:guid}}";
        }
    }
}
