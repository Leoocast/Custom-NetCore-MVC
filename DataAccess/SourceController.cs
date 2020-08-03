using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class SourceController : Controller
    {
        private Data _dataAccess;
        public Data Data
            => _dataAccess
            ?? (_dataAccess = new Data());
    }
}
