﻿namespace Characters
{
    class BasicTitanAnimations: BaseTitanAnimations
    {
        public override string Idle => "Amarture_VER2|idle";
        public string[] Runs = new string[] {"Amarture_VER2|run.abnormal", "Amarture_VER2|run.abnormal.1" };
        public override string Sprint => "Amarture_VER2|run.abnormal.1";
        public string RunCrawler = "Amarture_VER2|crawler.run";
        public string IdleCrawler = "Amarture_VER2|crawler.idle";
        public string JumpCrawler = "Amarture_VER2|attack.crawler.jump.0";
        public string FallCrawler = "Amarture_VER2|attack.crawler.jump.1";
        public string LandCrawler = "Amarture_VER2|attack.crawler.jump.2";
        public override string Walk => "Amarture_VER2|run.walk";
        public override string Jump => "Amarture_VER2|attack.jumper.0";
        public override string Fall => "Amarture_VER2|attack.jumper.1";
        public override string Land => "Amarture_VER2|attack.jumper.2";
        public override string Stun => "Amarture_VER2|hit.eren.L";
        public string StunLeft = "Amarture_VER2|hit.eren.L";
        public string StunRight = "Amarture_VER2|hit.eren.R";
        public string DieBack = "Amarture_VER2|die.back";
        public string DieFront = "Amarture_VER2|die.front";
        public string DieGround = "Amarture_VER2|die.ground";
        public string DieCrawler = "Amarture_VER2|crawler.die";
        public override string DieSit => "Amarture_VER2|sit_die";
        public string AttackPunchCombo = "Amarture_VER2|attack.combo";
        public string AttackPunch = "Amarture_VER2|attack.comboPunch";
        public string AttackSlam = "Amarture_VER2|attack.front.ground";
        public string AttackBellyFlop = "Amarture_VER2|attack.abnormal.jump";
        public string AttackBellyFlopGetup = "Amarture_VER2|attack.abnormal.getup";
        public string AttackKick = "Amarture_VER2|attack.kick";
        public string AttackStomp = "Amarture_VER2|attack.stomp";
        public string AttackSwingL = "Amarture_VER2|attack.swing.l";
        public string AttackSwingR = "Amarture_VER2|attack.swing.r";
        public string AttackBiteF = "Amarture_VER2|bite";
        public string AttackBiteL = "Amarture_VER2|bite.l";
        public string AttackBiteR = "Amarture_VER2|bite.r";
        public string AttackGrabAirFarL = "Amarture_VER2|grab.air.far.l";
        public string AttackGrabAirFarR = "Amarture_VER2|grab.air.far.r";
        public string AttackGrabAirL = "Amarture_VER2|grab.air.short.l";
        public string AttackGrabAirR = "Amarture_VER2|grab.air.short.r";
        public string AttackGrabBackL = "Amarture_VER2|grab.back.l";
        public string AttackGrabBackR = "Amarture_VER2|grab.back.r";
        public string AttackGrabCoreL = "Amarture_VER2|grab.core.L";
        public string AttackGrabCoreR = "Amarture_VER2|grab.core.R";
        public string AttackGrabGroundBackL = "Amarture_VER2|grab.ground.back.l";
        public string AttackGrabGroundBackR = "Amarture_VER2|grab.ground.back.r";
        public string AttackGrabGroundFrontL = "Amarture_VER2|grab.ground.front.l";
        public string AttackGrabGroundFrontR = "Amarture_VER2|grab.ground.front.r";
        public string AttackGrabHeadBackL = "Amarture_VER2|grab.head.back.l";
        public string AttackGrabHeadBackR = "Amarture_VER2|grab.head.back.r";
        public string AttackGrabHeadFrontL = "Amarture_VER2|grab.head.front.1";
        public string AttackGrabHeadFrontR = "Amarture_VER2|grab.head.front.r";
        public string AttackGrabHighL = "Amarture_VER2|grab.high.l";
        public string AttackGrabHighR = "Amarture_VER2|grab.high.r";
        public string AttackGrabStomachL = "Amarture_VER2|grab.stomach.l";
        public string AttackGrabStomachR = "Amarture_VER2|grab.stomach.r";
        public string AttackEatL = "Amarture_VER2|eat.l";
        public string AttackEatR = "Amarture_VER2|eat.r";
        public string AttackSlapHighL = "Amarture_VER2|attack.anti.AE.high.l";
        public string AttackSlapHighR = "Amarture_VER2|attack.anti.AE.high.r";
        public string AttackSlapL = "Amarture_VER2|attack.anti.AE.l";
        public string AttackSlapR = "Amarture_VER2|attack.anti.AE.r";
        public string AttackSlapLowL = "Amarture_VER2|attack.anti.AE.low.l";
        public string AttackSlapLowR = "Amarture_VER2|attack.anti.AE.low.r";
        public string AttackBrushChestL = "Amarture_VER2|attack.chest.L";
        public string AttackBrushChestR = "Amarture_VER2|attack.chest.R";
        public string AttackHitBack = "Amarture_VER2|attack.slap.back";
        public string AttackHitFace = "Amarture_VER2|attack.slap.face";
        public string AttackRockThrow = "Amarture_VER2|attack.throw";
        public string AttackJump = "Amarture_VER2|attack.jumper.0";
        public string AttackJumpCrawler = "Amarture_VER2|attack.crawler.jump.0";
        public override string SitIdle => "Amarture_VER2|sit_idle";
        public string SitIdleCrawler = "Amarture_VER2|crawler.sit.idle";
        public override string SitDown => "Amarture_VER2|sit_down";
        public override string SitUp => "Amarture_VER2|sit_getup";
        public string SitUpCrawler = "Amarture_VER2|crawler.getup";
        public override string SitFall => "Amarture_VER2|sit_hunt_down";
        public string SitFallCrawler = "Amarture_VER2|crawler.hunt.down";
        public override string Turn90L => "Amarture_VER2|turnaround.L";
        public override string Turn90R => "Amarture_VER2|turnaround.R";
        public string Turn90LCrawler = "Amarture_VER2|crawler.turnaround.L";
        public string Turn90RCrawler = "Amarture_VER2|crawler.turnaround.R";
        public override string Blind => "Amarture_VER2|hit.eye";
        public override string SitBlind => "Amarture_VER2|sit_hit_eye";
        public string BlindCrawler = "Amarture_VER2|crawler.hiteyes";
        public string ArmHurtL = "Amarture_VER2|arm_hurt_L";
        public string ArmHurtR = "Amarture_VER2|arm_hurt_R";
        public string EmoteLaugh = "Amarture_VER2|laugh";
        public string EmoteNod = "Amarture_VER2|emote_titan_yes";
        public string EmoteShake = "Amarture_VER2|emote_titan_no";
        public string EmoteRoar = "Amarture_VER2|attack.scream";
    }
}
