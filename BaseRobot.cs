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
            MakeMePretty();
            while (true)
            {
                Ahead(50);
                TurnGunLeft(360);
                Back(50);
            }
        }


        /// <summary>
        ///  Any movement or turning of anything will trigger a scan
        /// </summary>
        /// <param name="evnt"></param>
        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            Fire(1);
            base.OnScannedRobot(evnt);
        }


        public override void OnHitWall(HitWallEvent evnt)
        {
            base.OnHitWall(evnt);
        }

        public override void OnBulletHit(BulletHitEvent evnt)
        {
            base.OnBulletHit(evnt);
        }

        public override void OnHitByBullet(HitByBulletEvent evnt)
        {
            base.OnHitByBullet(evnt);
        }

        public override void OnHitRobot(HitRobotEvent evnt)
        {
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