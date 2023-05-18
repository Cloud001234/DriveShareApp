using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DriveShareApp.Core.Common
{
    public interface IDbContext
    {
        DbConnection Connection { get; }

    }
}
