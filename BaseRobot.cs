using System.Drawing;
using Robocode;

// Change namespace AND assembly name to {your_team_name}
 namespace YourTeamName
 {
    /// <summary>
    /// Name this class {your_robot_nickname}
    /// </summary>
    public class BaseRobot : Robot
    {
        public override void Run()
        {
            // Remember to change the colors in MakeMePretty to stand out in the crowd.
            MakeMePretty();
            base.Run();
            // Consult the API to expand your bot:
            // https://robocode.sourceforge.io/docs/robocode.dotnet/Index.html
            // 
            // Robot anatomy:
            // https://robowiki.net/wiki/Robocode/Robot_Anatomy

            
            while (true)
            {
                // Do robot stuff
                // X; // My X position
                // Y; // My Y position
                Ahead(50);
                TurnRight(90);
                Back(50);
                TurnGunLeft(360);
                
            }
        }


        /// <summary>
        ///  Any movement or turning of anything will trigger a scan
        /// </summary>
        /// <param name="evnt"></param>
        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            // Note that the gun cannot fire if the gun is overheated, meaning that GunHeat returns a value > 0.
            var firepower = 1;
            if (GunHeat == 0.0 && Energy > firepower)
            {
                Fire(firepower);
            }
            // Lower power == faster bullet velocity
            // Fire() consumes energy.
            // Max power(depletes energy repository): 3.0
            // Min power: 0.1
            // 
            // Damage you impose on hit:  4 * power + max(0, 2 * (power - 1) )
            
            // Do I shoot? https://robowiki.net/wiki/When_To_Fire 
            
            // Hitting someone retrieves some of the lost energy.
           
            // Calculating distance:
            // All coordinates are expressed as (x,y).
            // All coordinates are positive.
            // Physics:
            // https://robowiki.net/wiki/Robocode/Game_Physics
            
            // The origin (0,0) is at the bottom left of the screen.
            // Find your coordinates by accessing Robot.X and Robot.Y
            // Heading - absolute angle in degrees with 0 facing up the screen, positive clockwise. 0 <= heading < 360.
            // Bearing - relative angle to some object from your robot's heading, positive clockwise. -180 < bearing <= 180

            // evnt.Energy;
            // evnt.Bearing;
            // evnt.Heading;
            // evnt.Distance;

            base.OnScannedRobot(evnt);
        }


        public override void OnHitWall(HitWallEvent evnt)
        {
            base.OnHitWall(evnt);
        }

        public override void OnBulletHit(BulletHitEvent evnt)
        {
            // Hitting someone retrieves energy
            base.OnBulletHit(evnt);
        }

        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            // Tip: Do something here. 
            base.OnHitByBullet(evnt);
        }

        public override void OnHitRobot(HitRobotEvent evnt)
        {
            // Tip: This is when you ram into another robot (or another robot rams into you)
            base.OnHitRobot(evnt);
        }

        public override void OnBulletMissed(BulletMissedEvent evnt)
        {
            base.OnBulletMissed(evnt);
        }
        
        
        
        /// <summary>
        /// Make your robot truly unique not only in behaviour, but also in looks.
        /// Applies a curated selection of System.Drawing.Colors to your robot's various body parts, projectiles and diagnostic tools
        /// </summary>
        private void MakeMePretty()
        {
            // Set colors
            BodyColor = (Color.Pink);
            GunColor = (Color.HotPink);
            RadarColor = (Color.LightPink);
            BulletColor = (Color.DeepPink);
            ScanColor = (Color.MediumVioletRed);
        }

    }
}