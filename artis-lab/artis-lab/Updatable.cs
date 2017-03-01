using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace artis_lab
{
    public interface Updatable
    {
        String save(String authToken);
        String update(Dictionary<String, String> newValues, String authToken);
        String delete(String key, String authToken);
    }
}
