using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TradeTracker.DATA.Enums
{
    public enum ReasonForEntry
    {
        [Display(Name = "Double top")]
        DoubleTop,
        [Display(Name = "Tripple top")]
        TrippleTop,
        [Display(Name = "Double bottom")]
        DoubleBottom,
        [Display(Name = "Tripple bottom")]
        TrippleBottom,
        [Display(Name = "Head and Shoulders")]
        HeadAndShoulders,
        [Display(Name = "Head and Shoulders Reversed")]
        ReversedHeadAndShoulders,
        [Display(Name = "Support Area")]
        SupportArea,
        [Display(Name = "Resistance Area")]
        ResistanceArea,
        [Display(Name = "Rising Wedge")]
        RisingWedge,
        [Display(Name = "Falling Wedge")]
        FallingWedge,
        [Display(Name = "Rectangle Bearish")]
        RectangleBearish,
        [Display(Name = "Rectangle Bearish")]
        RectangleBullish,
        [Display(Name = "Pennant Bullish")]
        PennantBullish,

        [Display(Name = "Pennant Bearish")]
        PennantBearish,

        [Display(Name = "Running Flat")]
        RunningFlat,

        [Display(Name = "Contracting Flat")]
        ContractingFlat,

        [Display(Name = "Expanding Flat")]
        ExpandingFlat,

        [Display(Name = "Fibonnaci Level")]
        FibonacciLevel,

        [Display(Name = "Inside Bar")]
        InsideBar,
        
        [Display(Name = "Butterfly Bullish")]
        ButterflyBullish,

        [Display(Name = "Gartley Bullish")]
        GartleyBullish,

        [Display(Name = "Bat Bullish")]
        BatBullish,

        [Display(Name = "Crab Bullish")]
        CrabBullish,

        [Display(Name = "Deep Crab Bullish")]
        DeepCrabBullish,

        [Display(Name = "Cypher Bullish")]
        CypherBullish,

        [Display(Name = "Shark Bullish")]
        SharkBullish,

        [Display(Name = "5-0 Bullish")]
        FiveZeroBullish,

        [Display(Name = "AB=CD Bullish")]
        ABCDBullish,

        [Display(Name = "AB=CD Extension Bullish")]
        ABCDExtensionBullish,

        [Display(Name = "Three Drives Pattern")]
        ThreeDrivesBullish,

        [Display(Name = "Butterfly Bearish")]
        ButterflyBearish,

        [Display(Name = "Gartley Bearish")]
        GartleyBearish,

        [Display(Name = "Bat Bearish")]
        BatBearish,
        

        [Display(Name = "Crab Bearish")]
        CrabBearish,

        [Display(Name = "Deep Crab Bearish")]
        DeepCrabBearish,

        [Display(Name = "CypherBearish")]
        CypherBearish,

        [Display(Name = "Shark Bearish")]
        SharkBearish,

        [Display(Name = "5-0 Bearish")]
        FiveZeroBearish,

        [Display(Name = "AB=CD Bearish")]
        ABCDBearish,

        [Display(Name = "AB=CD Extension Bearish")]
        ABCDExtensionBearish,

        [Display(Name = "Three Drives Bearish")]
        ThreeDrivesBearish,

        
        Doji,

        [Display(Name = "Abandoned Baby")]
        AbandonedBaby,

        [Display(Name = "Harami Cross")]
        HaramiCross,

        [Display(Name = "Dragon Fly Doji")]
        DragonFlyDoji,

        [Display(Name = "Morning Star Doji")]
        MorningStarDoji,

        [Display(Name = "Evening Star Doji")]
        EveningStarDoji,

        [Display(Name = "Gravestone Doji")]
        GravestoneDoji,

        [Display(Name = "Evening Star")]
        EveningStar,

        [Display(Name = "Morning Star")]
        MorningStar,

       
        Hammer,

        [Display(Name = "Hammer Inverted")]
        HammerInverted,

        [Display(Name = "Hanging Man")]
        HangingMan,

        [Display(Name = "Spinning Top")]
        SpinningTop,

        [Display(Name = "Shooting Star")]
        ShootingStar,

        [Display(Name = "DarkCloudCover")]
        DarkCloudCover,

        [Display(Name = "Engulfing Candle")]
        EngulfingCandle,

        Harami,

        Stars,

        [Display(Name = "Stick Sandwich")]
        StickSandwich,

        [Display(Name = "Three Black Crows")]
        ThreeBlackCrows,

        [Display(Name = "Three White Soldiers")]
        ThreeWhiteSoldiers,

        [Display(Name = "Trend continuation")]
        TrendContinuation,

        Diamond


    }
}
