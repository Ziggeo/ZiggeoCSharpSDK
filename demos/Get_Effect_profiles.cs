using System;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Get_Effect_profile
{
    public class Get_Effect_profiles
    {
		public object Get_Video()
		{

			Ziggeo ziggeo = new Ziggeo("APP_TOKEN", "PRIVATE_KEY", "ENCRYPTION_KEY");

			dynamic EffectProfile = JsonConvert.DeserializeObject(ziggeo.effectProfiles().index());

			return (EffectProfile);
		}
    }
}
