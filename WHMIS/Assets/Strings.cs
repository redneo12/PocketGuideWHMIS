﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace WHMIS
{
    public static class Strings
    {
        /*******************************************************************/
        // GLOBAL STRINGS
        /*******************************************************************/
        public static string courseTitle = "WHMIS";


        /*******************************************************************/
        // Image links
        /*******************************************************************/
        public static string LogoYowPath = "WHMIS.Assets.Images.1-YOW_WEB.png";
        public static string LogoYowPath_W = "WHMIS.Assets.Images.1-YOW_Print_Text_white.png";
        public static string LogoYowSmallPath = "WHMIS.Assets.Images.1-YOW_WEB.png";
        //public static string LogoYowSmallPath_W = "WHMIS.Assets.Images.logo_yow_small_white.png";



        //icons
        //https://dev.materialdesignicons.com/getting-started/xamarin
        //https://cdn.materialdesignicons.com/4.7.95/
        //<!--Example: FONTFAMILY MUST BE SET-->
        //   <!--<Button Text = "&#xf844;"
        //      TextColor="Green"
        //      BackgroundColor="Transparent"
        //      FontFamily="{StaticResource IconFont}"
        //      FontSize="Medium" />-->
        public static string IconSearch = "&#xF349;";
        public static string IconCancle = "&#xF739;";
        public static string IconHome = "&#xF2DC;";
        public static string IconPlus = "&#xF415;";
        public static string IconPlusBox = "&#xF703;";
        public static string IconNotePlus = "&#xFEC8;";
        public static string IconMinus = "&#xF374;";
        public static string IconMinusBox = "&#xF6F1;";
        public static string IconBookmark = "&#xF0C3;";
        public static string IconBookmarkAdd = "&#xF0C4;";
        public static string IconBookmarkOff = "&#xF9CE;";
        public static string IconArrowLeft = "&#xF04D;";
        public static string IconArrowRight = "&#xF054;";
        public static string IconInfo = "&#xF64E;";
        //public static object IconFont = Application.Current.Resources["IconFont"];

        /*******************************************************************/
        //Image WHMIS
        //Pictograms
        public static string ImgWhmisPicCorrosive = "WHMIS.Assets.Images.WHMIS.corrosive.png";
        public static string ImgWhmisPicEnviroToxic = "WHMIS.Assets.Images.WHMIS.enviro_toxic.png";
        public static string ImgWhmisPicExclamation = "WHMIS.Assets.Images.WHMIS.exclamation.png";
        public static string ImgWhmisPicExplosive = "WHMIS.Assets.Images.WHMIS.explosion.png";
        public static string ImgWhmisPicFire = "WHMIS.Assets.Images.WHMIS.fire.png";
        public static string ImgWhmisPicGas = "WHMIS.Assets.Images.WHMIS.gas.png";
        public static string ImgWhmisPicHealth = "WHMIS.Assets.Images.WHMIS.health.png";
        public static string ImgWhmisPicOxflame = "WHMIS.Assets.Images.WHMIS.oxflame.png";
        public static string ImgWhmisPicSkull = "WHMIS.Assets.Images.WHMIS.skull.png";
        public static string ImgWhmisPicBio = "WHMIS.Assets.Images.WHMIS.biohazard.png";

        //Pictograms Old
        public static string ImgWhmisPicClassA = "WHMIS.Assets.Images.WHMIS.classA.png";
        public static string ImgWhmisPicClassB = "WHMIS.Assets.Images.WHMIS.classB.png";
        public static string ImgWhmisPicClassC = "WHMIS.Assets.Images.WHMIS.classC.png";
        public static string ImgWhmisPicClassD1 = "WHMIS.Assets.Images.WHMIS.classD1.png";
        public static string ImgWhmisPicClassD2 = "WHMIS.Assets.Images.WHMIS.classD2.png";
        public static string ImgWhmisPicClassD3 = "WHMIS.Assets.Images.WHMIS.classD3.png";
        public static string ImgWhmisPicClassE = "WHMIS.Assets.Images.WHMIS.classE.png";
        public static string ImgWhmisPicClassF = "WHMIS.Assets.Images.WHMIS.classF.png";

        //PTE
        public static string ImgWhmisPPEApron = "WHMIS.Assets.Images.WHMIS.apron.png";
        public static string ImgWhmisPPEBody = "WHMIS.Assets.Images.WHMIS.bodysuit.png";
        public static string ImgWhmisPPEBoots = "WHMIS.Assets.Images.WHMIS.boots.png";
        public static string ImgWhmisPPECartidge = "WHMIS.Assets.Images.WHMIS.cartridge-respirator.png";
        public static string ImgWhmisPPEDust = "WHMIS.Assets.Images.WHMIS.dust-mask.png";
        public static string ImgWhmisPPEFace = "WHMIS.Assets.Images.WHMIS.face-shield.png";
        public static string ImgWhmisPPEFull = "WHMIS.Assets.Images.WHMIS.full-face-mask.png";
        public static string ImgWhmisPPEGloves = "WHMIS.Assets.Images.WHMIS.gloves.png";
        public static string ImgWhmisPPEGoggles = "WHMIS.Assets.Images.WHMIS.goggles.png";
        public static string ImgWhmisPPESupplied = "WHMIS.Assets.Images.WHMIS.supplied-air-respirator.png";

        //Lables
        public static string ImgWhmisSupplierLable = "WHMIS.Assets.Images.WHMIS.Supplier-Label2017.png";
        public static string ImgWhmisWorplaceLable = "WHMIS.Assets.Images.WHMIS.workplace-lable.png";
        public static string ImgSimdutWorplaceLable = "WHMIS.Assets.Images.WHMIS.workplace-lable_FRENCH.png";

        //PG Images
        public static string ImgWhmisPicLadyLaw = "WHMIS.Assets.Images.WHMIS.imgLadyLiberty.jpg";
        public static string ImgWhmisPicBarle = "WHMIS.Assets.Images.WHMIS.imgBarle.jpg";
        public static string ImgWhmisPicExemptions = "WHMIS.Assets.Images.WHMIS.imgExemptions.jpg";
        public static string ImgWhmisPicExemptions2 = "WHMIS.Assets.Images.WHMIS.imgExemptions2.jpg";
        public static string ImgWhmisPicConsumer = "WHMIS.Assets.Images.WHMIS.imgConsumer.jpg";



        /*******************************************************************/
        //Image PDFs / Files
        public static string ImgWhmisHTMLSDS = "WHMIS.Assets.Images.WHMIS.speedy_sds.html";
        public static string ImgSimdutHTMLFDS = "WHMIS.Assets.Images.WHMIS.speedy_fds.html";


        /*******************************************************************/
        //Colours   http://www.yowcanada.com/css/YOW-COLOUR%20TABLE.html
        /*******************************************************************/
        public static string ColYowBlue = "#003D79";
        public static string ColYowLBlue = "#D2E0FF";
        public static string ColYowMBlue = "#AEC7FF";
        public static string ColYowM2Blue = "#31639C";

        public static string ColYowGrey = "#CDCDCD";
        public static string ColYowLGrey = "#EEEEEE";
        public static string ColYowDarkGrey = "#535353";

        public static string ColYowOrange = "#FF8208";

        public static string ColYowLink = "#019DCE";


    }
}
