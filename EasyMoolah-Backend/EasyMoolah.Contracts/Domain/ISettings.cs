using EasyMoolah.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMoolah.Contracts.Domain
{
    public interface ISettings
    {
        ApplicationSettings ApplicationSettings { get; set; }
    }
}
