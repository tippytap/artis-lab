using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artis_lab
{
    interface Updatable
    {
        String save(String authToken);
        String update(String authToken);
        String delete(String key, String authToken);
    }
}
