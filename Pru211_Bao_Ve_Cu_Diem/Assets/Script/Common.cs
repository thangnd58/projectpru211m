using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
	public class Common
	{
		//For gun Script
		public static int maxBullet = 10; //maximum the bullet fire
		public static int cooldownTime = 2; //time for cooldown fill max bullet
		public static float bulletSpeed = 12f; //bullet force
		public static float rotateSpeed = 100f; // The speed at which the Stick rotates, in degrees per second

		//For wall script
		public static float maxHealth = 100.0f;
		public static float healthLeft;

		public static int money;
	}
}
