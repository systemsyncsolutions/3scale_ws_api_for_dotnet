using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CS_threescale
{
    public interface IApi
    {
        //AuthorizeResponse authrep(Hashtable parameters);

        //AuthorizeResponse authorize(Hashtable parameters);

        Task<AuthorizeResponse> oauth_authorizeAsync(Hashtable parameters);

        Task reportAsync(Hashtable transactions);

        string HostURI
        {
            get;
            set;
        }
    }
}
