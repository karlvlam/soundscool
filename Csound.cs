/*
 * Created by SharpDevelop.
 * User: karl
 * Date: 10/5/2008
 * Time: 1:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace soundscool
{
	/// <summary>
	/// All Classes related to Csounds, Wav file
	/// </summary>
	public class Csound
	{
		public static string NL = "\r\n";
		public bool bRing, bHP, bHPd, bLP, bLPd;
		public bool bDelay, bDistort;
		private string csoundExe;
		private string inWav, outWav; // input/output wav file path
		private int feqShift, feqShiftLow;	//-3000 - +3000
		private double feqScale;	//0.125 - 8
		private double wavLength, destLength; // input/output wav file duration, in sec
		private double blurTime, ampCF, feqCF;
		private double ampScale;
		private double delayTime, delayFB, delayDWM;
		private double distPregain, distPostgain, distPS, distNS;
		private double arpDepth, arpGain, lfoDepth, lfoSpeed, lfoOffset;
		private double hpco, lpco, ringco;
		

		public Csound()
		{
			csoundExe = @"C:\Program Files\Csound\bin\csound.exe";

			inWav = null;
			outWav = null;
			
			this.reset();

		}
		
		public void reset(){
			bRing=bHP=bHPd=bLP=bLPd=bDelay=bDistort = false;
			feqShift = 0; feqShiftLow = 0; feqScale = 1;
			blurTime = 0; ampCF = 1; feqCF = 1;
			ampScale = 1;			
			wavLength = -1;
			destLength = 0;
			
			delayTime =0.1;
			delayDWM = 0.3;
			delayFB = 0;
			
			
			distPregain = 1; distPostgain = 0.4; distPS = 0; distNS = 0;
			arpDepth=arpGain=lfoDepth=lfoOffset=0;
			lfoSpeed = 3;
			
			hpco = 2000;
			lpco = 200;
			ringco = 0.1;
		}
		
		// convert path "c:\dir\file.ext" -> "c:/dir/file.ext" Csound format
		public static string csoundPath(string s){
			if (s == null) return null;
			return s.Replace("\\", "/");
		}
		
		public string b2s(bool b){
			if(b) return "1";
			return "0";
		}
		
		public string getCsoundExe(){return csoundExe;}
		public string getInWav(){return inWav;}
		public string getOutWav(){return outWav;}
		public double getWavLength(){return wavLength;}
		public double getDestLength(){return destLength;}
		public int getFeqShift(){return feqShift;}
		public int getFeqShiftLow(){return feqShiftLow;}
		public double getFeqScale(){return feqScale;}
		public double getBlurTime(){return blurTime;}
		public double getAmpCF(){return ampCF;}
		public double getFeqCF(){return feqCF;}
		public double getAmpScale(){return ampScale;}
		
		public double getDelayTime(){return delayTime;}
		public double getDelayFB(){return delayFB;}
		public double getDelayDWM(){return delayDWM;}
		
		public double getDistPregain(){return distPregain;}
		public double getDistPostgain(){return distPostgain;}
		public double getDistPS(){return distPS;}
		public double getDistNS(){return distNS;}
			
		
		public double getArpDepth(){return arpDepth;}
		public double getArpGain(){return arpGain;}
		public double getLfoDepth(){return lfoDepth;}
		public double getLfoSpeed(){return lfoSpeed;}
		public double getLfoOffset(){return lfoOffset;}
		public double getHpco(){return hpco;}
		public double getLpco(){return lpco;}
		public double getRingco(){return ringco;}

		
		public bool setCsoundExe(string s){
			if(File.Exists(s)){
				csoundExe = s;
				return true;
			}
			return false;
		}
		public bool setWavLength(double d){
			if(d >= 0){
				wavLength = d;
				destLength = d;
				return true;
			}
			
			return false;
		}
		
		public bool setDestLength(double d){
			if(d >= 0){				
				destLength = d;
				return true;
			}
			
			return false;
		}
		
		public bool setInWav(string s){
			
			if (File.Exists(s)){
				this.inWav = s;
				return setWavLength(Math.Ceiling(wavDuration(s) * 100) / 100);
			}	
							
			return false;
		}
		
		public bool setOutWav(string s){
			
			if(Directory.Exists(Path.GetDirectoryName(s))){
				outWav = s;
				return true;
			}
			
			return false;
		}
		
	    // get the WAVE file time length in sec
        public static double wavDuration(string s){
        	FileInfo fi;
        	System.IO.FileStream fs;
        	try{	        	
	            fi = new FileInfo(s);
	            fs = fi.OpenRead();
	            if(fs.Length>=44)
	            {
	                byte[] bInfo=new byte[44];
	                fs.Read(bInfo,0,44);
	                System.Text.Encoding.Default.GetString(bInfo,0,4);
	                if(System.Text.Encoding.Default.GetString(bInfo,0,4)=="RIFF" && System.Text.Encoding.Default.GetString(bInfo,8,4)=="WAVE" && System.Text.Encoding.Default.GetString(bInfo,12,4)=="fmt ")
	                {
	                    
	                    return (double)System.BitConverter.ToInt32(bInfo,40) / (double)System.BitConverter.ToUInt32(bInfo,28);
	
	                }
	
	            }
        	}catch(Exception e){
        		//System.Windows.Forms.MessageBox.Show(e.ToString());
        		return -2;
        	}
            
            return -1;

        }
	    public bool setFeqShift(int i){
	    	if(i < -3000){
	    		this.feqShift = -3000;
	    		return true;
	    	}
	    	if(i > 3000){
	    		this.feqShift = 3000;
	    		return true;
	    	}
	    	this.feqShift = i;
	    	return true;
	    }
	    
	       public bool setFeqShiftLow(int i){
	    	if(i < -3000){
	    		this.feqShiftLow = -3000;
	    		return true;
	    	}
	    	if(i > 3000){
	    		this.feqShiftLow = 3000;
	    		return true;
	    	}
	    	this.feqShiftLow = i;
	    	return true;
	    }
		public bool setFeqScale(double d){
	    	if(d < 0.125){
	    		this.feqScale = 0.125;
	    		return true;
	    	}
	    	if(d > 8){
	    		this.feqScale = 8;
	    		return true;
	    	}
	    	this.feqScale = d;
	    	return true;
	    }
	    public bool setBlurTime(double d){
	    	if(d < 0){
	    		this.blurTime = 0;
	    		return true;
	    	}
	    	if(d > 3){
	    		this.blurTime = 3;
	    		return true;
	    	}
	    	this.blurTime = d;
	    	return false;
	    }
	    
	    public bool setAmpCF(double d){
	    	if(d < 0){
	    		this.ampCF = 0;
	    		return true;
	    	}
	    	if(d > 1){
	    		this.ampCF = 1;
	    		return true;
	    	}
	    	this.ampCF = d;
	    	return true;
	    }
	    
	    public bool setFeqCF(double d){
	    	if(d < 0){
	    		this.feqCF = 0;
	    		return true;
	    	}
	    	if(d > 1){
	    		this.feqCF = 1;
	    		return true;
	    	}
	    	this.feqCF = d;
	    	return true;
	    }
	    
		public bool setAmpScale(double d){
	    	if(d < 0){
	    		this.ampScale = 0;
	    		return true;
	    	}
	    	if(d > 10){
	    		this.ampScale = 10;
	    		return true;
	    	}
	    	this.ampScale = d;
	    	return true;
	    }
	    
	    public bool setDelayTime(double d){
	    	double min = 0;
	    	double max = 5;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.delayTime = d;
	    	return true;
	    }
	    
	   	public bool setDelayFB(double d){
	    	double min = -0.95;
	    	double max = 0.95;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.delayFB = d;
	    	return true;
	    }
		public bool setDelayDWM(double d){
	    	double min = 0;
	    	double max = 1;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.delayDWM = d;
	    	return true;
	    }
	    
	    public bool setDistPregain(double d){
	    	double min = 0;
	    	double max = 100;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.distPregain = d;
	    	return true;
	    }
	    
	   	public bool setDistPostgain(double d){
	    	double min = 0.001;
	    	double max = 1;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.distPostgain = d;
	    	return true;
	    }
	    
	    public bool setDistPS(double d){
	    	double min = 0;
	    	double max = 1;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.distPS = d;
	    	return true;
	    }
	    
	    public bool setDistNS(double d){
	    	double min = 0;
	    	double max = 1;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.distNS = d;
	    	return true;
	    }
	    
	    public bool setHpco(double d){
	    	double min = 20;
	    	double max = 20000;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.hpco = d;
	    	return true;
	    }
	    
	    public bool setLpco(double d){
	    	double min = 20;
	    	double max = 20000;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.lpco = d;
	    	return true;
	    }
	    public bool setRingco(double d){
	    	double min = 0.1;
	    	double max = 100;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.ringco = d;
	    	return true;
	    }
	    
	    public bool setArpDepth(double d){
	    	double min = 0;
	    	double max = 1;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.arpDepth = d;
	    	return true;
	    }
	    public bool setArpGain(double d){
	    	double min = 0;
	    	double max = 10;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.arpGain = d;
	    	return true;
	    }
	    public bool setLfoDepth(double d){
	    	double min = 0;
	    	double max = 0.5;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.lfoDepth = d;
	    	return true;
	    }
	   	public bool setLfoSpeed(double d){
	    	double min = 0.001;
	    	double max = 2000;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.lfoSpeed = d;
	    	return true;
	    }
	    public bool setLfoOffset(double d){
	    	double min = -0.5;
	    	double max = 0.5;	    	
	    	if(d < min){
	    		d = min;
	    		
	    	}
	    	if(d > max){
	    		d = max;	    		
	    	}
	    	this.lfoOffset = d;
	    	return true;
	    }
	    // ##########################################
	    // check if file-2-file is ready to run
	    public bool readyFile(){
	    	if ((this.inWav != null) && (this.outWav != null)){
	    		return true;
	    	}
	    	return false;
	    }
	    

				
	    public bool runLiveWav(string wavFile){
	    	
	    	ASCIIEncoding ascEnc = new ASCIIEncoding();			
			//byte[] bs = ascEnc.GetBytes(this.genLiveWavCSD(wavFile));
			byte[] bs = ascEnc.GetBytes(this.genLiveWavCSD(wavFile));
			string tmp = Path.GetTempPath() + ".csd";
			
			try{
				FileStream fs = File.OpenWrite(tmp);
				fs.Write(bs,0,bs.Length);
				fs.Close();
			}catch(Exception ){
				return false;
			}
			
			Process p = null;
			
			try{				
				
				//p = Process.Start(this.csoundExe," -o \"" + outWav + "\"  \"" + tmp + "\"");
				p = Process.Start(this.csoundExe, " \"" + tmp + "\"");
			}catch(Exception){
				return false;
			}
			
			/*
			while(!p.HasExited){}
			
			if (p.ExitCode == 0){
				return true;
			}*/
		
	    	return true;
	    }
	    
	    public string genLiveWavCSD(string wavFile){
	    	wavFile = csoundPath(wavFile);
	    	string csdString = "<CsoundSynthesizer>" + NL +

				"<CsOptions>" + NL +
				"-idevaudio -odevaudio -b400" + NL +
				"</CsOptions>" + NL +
				
				"<CsInstruments>" + NL +
				
				"sr 		= 	44100" + NL +
				"kr 		= 	441" + NL +
				"ksmps 		= 	100" + NL +
				"nchnls 		= 	2" + NL +
				
				
				";Main panel" + NL +
				"iWinWidth	=	640" + NL +
				"iWinHeight	=	480" + NL +
				"iDisplayWidth	=	60" + NL +
				"iDisplayHeight	=	20" + NL +
				"iSliderWidth	=	iWinWidth - 30 - iDisplayWidth" + NL +
				"iSliderHeight	=	10" + NL +
					"FLpanel	\"Voice Changer --- "+ wavFile +" \",   iWinWidth,     iWinHeight,    0,  0" + NL +
				
					"FLlabel		15, 2, 1" + NL +
				"gkOnOff,gihOnOff	FLbutton	\"On/Off\", 1, 0, 2, 100, 30, 10,            10, 0, 1, 0, -1" + NL +
				"gkReset,gihReset	FLbutton	\"Reset\",  1, 0, 1, 100, 30, iWinWidth-110, 10, 0, 2, 0,  1" + NL +
				
					"FLlabel		15, 1, 1" + NL +
				"iScaleDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 50" + NL +
				"iShiftDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 80" + NL +
				"iLowestShiftDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 110" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkScale,gihScale 	FLslider	\"Frequency Rescale\",         0.125,    8, -1, 5,       iScaleDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 50" + NL +
				"gkShift,gihShift 	FLslider	\"Frequency Shifting\",        -3000, 3000,  0, 5,       iShiftDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 80" + NL +
				"gkLowestShift,gihLowestShift FLslider	\"Lowest Frequency to Shift\", -3000, 3000,  0, 5, iLowestShiftDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 110" + NL +
				
					"FLlabel		15, 1, 1" + NL +
				"gkAmpFrz,gihAmpFrz	FLbutton	\"Freeze Amplitude\",                  1, 0, 2, 150, 30, 10,  150, 0, -1" + NL +
				"gkFreqFrz,gihFreqFrz	FLbutton	\"Freeze Frequency\",                  1, 0, 2, 150, 30, 170, 150, 0, -1" + NL +
				"gkBothFrz,gihBothFrz	FLbutton	\"Freeze Both Amplitude & Frequency\", 1, 0, 2, 300, 30, 330, 150, 0,  3, 0, 1" + NL +
				
				"iBlurDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				"	" + NL +
				"	FLlabel		15, 1, 3" + NL +
				"gkBlur,gihBlur		FLslider	\"Blurring Time\", 0, 3, 0, 5, iBlurDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 200" + NL +
				
				"iAmpSmthDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 240" + NL +
				"iFreqSmthDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 270" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkAmpSmth,gihAmpSmth	FLslider	\"Amplitude Smoothing Cutoff Frequency\", 0, 1, 0, 5,  iAmpSmthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 240" + NL +
				"gkFreqSmth,gihFreqSmth	FLslider	\"Frequency Smoothing Cutoff Frequency\", 0, 1, 0, 5, iFreqSmthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 270" + NL +
				
					"FLlabel		15, 1, 1" + NL +
				"gkSmthLock, gihSmthLock FLbutton	\"Smoothing Amplitude = Smoothing Frequency\", 1, 0, 3, 350, 30, 10, 290, 0, 4, 0, -1" + NL +
				
				"iArpDepthDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 330" + NL +
				"iArpGainDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 360" + NL +
				"iLFODepthDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 390" + NL +
				"iLFOSpeedDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 420" + NL +
				"iLFOOffsetDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 450" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkArpDepth,gihArpDepth		FLslider	\"Arpeggiate Depth\",                   0,    1,  0, 5,  iArpDepthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 330" + NL +
				"gkArpGain,gihArpGain		FLslider	\"Arpeggiate Gain Rescale\",            0,   10,  0, 5,   iArpGainDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 360" + NL +
				"gkLFODepth,gihLFODepth		FLslider	\"Low Frequency Oscillator Depth\",     0,  0.5,  0, 5,  iLFODepthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 390" + NL +
				"gkLFOSpeed,gihLFOSpeed		FLslider	\"Low Frequency Oscillator Speed\", 0.001, 2000, -1, 5,  iLFOSpeedDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 420" + NL +
				"gkLFOOffset,gihLFOOffset	FLslider	\"Low Frequency Oscillator Offset\", -0.5,  0.5,  0, 5, iLFOOffsetDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 450" + NL +
				
				";Initialize values" + NL +
					"FLsetVal_i	1, 	gihScale" + NL +
					"FLsetVal_i	0, 	gihShift   " + NL +
					"FLsetVal_i	0, 	gihLowestShift" + NL +
					"FLsetVal_i	0,	gihBlur" + NL +
					"FLsetVal_i	1,	gihAmpSmth" + NL +
					"FLsetVal_i	1,	gihFreqSmth" + NL +
					"FLsetVal_i	0, 	gihArpDepth" + NL +
					"FLsetVal_i	0, 	gihArpGain" + NL +
					"FLsetVal_i	0, 	gihLFODepth" + NL +
					"FLsetVal_i	3, 	gihLFOSpeed" + NL +
					"FLsetVal_i	0, 	gihLFOOffset" + NL +
				"          " + NL +
					"FLpanel_end" + NL +
				
				
				";Filter panel" + NL +
				"iWin2Width = 640" + NL +
				"iWin2Height = 550" + NL +
				"iSliderWidth2 = iWin2Width - 30 - iDisplayWidth" + NL +
				"iSliderHeight2 = 10" + NL +
					"FLpanel		\"Filter panel "+wavFile+" \", iWin2Width, iWin2Height, iWinWidth, 0" + NL +
				"	" + NL +
				"	FLlabel		15, 2, 1" + NL +
				
				"gkReset2,gihReset2	FLbutton	\"Reset\",  1, 0, 1, 100, 30, iWinWidth-110, 10, 0, 8, 0,  1" + NL +
				
				"gkDelayChk, gihDelayChk	FLbutton	\"Delay filter\", 1, 0, 3, 150, 30, 10, 10, 0, 5, 0, -1" + NL +
				
				"iDelayTimeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 40" + NL +
				"iDelayDWMDisplay	FLvalue 	\" \", iDisplayWidth, iDisplayHeight, 10, 70" + NL +
				"iDelayFBDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 100" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkDelayTime, gihDelayTime	FLslider	\"Delay Time\",        0, 5, 0, 5, iDelayTimeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 40" + NL +
				"gkDelayDWM, gihDelayDWM		FLslider	\"Delay Dry/Wet Mix\", 0, 1, 0, 5,  iDelayDWMDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 70" + NL +
				"gkDelayFB, gihDelayFB		FLslider	\"Delay Feedback Amount\", -0.95, 0.95, 0, 5,  iDelayFBDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 100" + NL +
				
					"FLlabel		15, 2, 1" + NL +
				";gkCombChk, gihCombChk	FLbutton	\"Comb filter\", 1, 0, 3, 150, 30, 10, 140, 0, 6, 0, -1" + NL +
				
				";iCombRTimeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 170" + NL +
				";iCombLTimeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				";iCombAScaleDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				
					"FLlabel 15,1,3" + NL +
				";gkCombRTime, gihCombRTime	FLslider	\"Comb Reverb Time\",              0.0001,  10, -1, 5,  iCombRTimeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 170" + NL +
				";gkCombLTime, gihCombLTime	FLslider	\"Comb Loop Time\",                0.0001, 0.1, -1, 5,  iCombLTimeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 200" + NL +
				";gkCombAScale, gihCombAScale	FLslider	\"Comb Output Amplitude Scaling\",      0,   1,  0, 5, iCombAScaleDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 200" + NL +
				
					"FLlabel 15,2,1" + NL +
				"gkDistChk, gihDistChk	FLbutton	\"Distort filter\", 1, 0, 3, 150, 30, 10, 140, 0, 7, 0, -1" + NL +
				
				"iDistPregainDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 170" + NL +
				"iDistPostgainDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				"iDistPShapeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10 ,230" + NL +
				"iDistNShapeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 260" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkDistPregain, gihDistPregain	FLslider	\"Pregain\",                       0, 100,  0, 5,  iDistPregainDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 170" + NL +
				"gkDistPostgain,gihDistPostgain	FLslider	\"Postgain\",                  0.001,   1, -1, 5, iDistPostgainDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 200" + NL +
				"gkDistPShape,  gihDistPShape	FLslider	\"Shape for Positive Signal\",     0,   1,  0, 5,   iDistPShapeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 230" + NL +
				"gkDistNShape,  gihDistNShape	FLslider	\"Shape for Negative Signal\",     0,   1,  0, 5,   iDistNShapeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 260" + NL +
				
					"FLlabel	15,2,1" + NL +
				"gkRMChk, gihRMChk		FLbutton	\"Ring Modulation\", 1, 0, 3, 150, 30, 10, 300, 0, 11, 0, -1" + NL +
				";iRMAmpDisplay			FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 330" + NL +
				"iRMFreqDisplay			FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 330" + NL +
				
					"FLlabel	15,1,3" + NL +
				";gkRMAmp, gihRMAmp		FLslider	\"Sine wave Amplitude\", 0, 100, 0, 5,  iRMAmpDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 330" + NL +
				"gkRMFreq, gihRMFreq		FLslider	\"Sine wave Frequency\", 0.1,  100, 0, 5, iRMFreqDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 330" + NL +
				
					"FLlabel 15,2,1" + NL +
				"gkHPassChk, gihHPassChk		FLbutton	\"High Pass Filter\", 1, 0, 3, 150, 30, 10,  370, 0,   9, 0, -1" + NL +
				"gkHPassDouble, gihHPassDouble	FLbutton	\"Double filtering\", 1, 0, 3, 150, 30, 170, 370, 0,  -1" + NL +
				"iHPassCutoffDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 400" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkHPassCutoff, gihHPassCutoff	FLslider	\"High Pass Cutoff Frequency\", 20, 20000, -1, 5, iHPassCutoffDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 400" + NL +
				
					"FLlabel 15,2,1" + NL +
				"gkLPassChk, gihLPassChk		FLbutton	\"Low Pass Filter\", 1, 0, 3, 150, 30, 10,  440, 0,   10, 0, -1" + NL +
				"gkLPassDouble, gihLPassDouble	FLbutton	\"Double filtering\", 1, 0, 3, 150, 30, 170, 440, 0,  -1" + NL +
				"iLPassCutoffDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 470" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkLPassCutoff, gihLPassCutoff	FLslider	\"Low Pass Cutoff Frequency\", 20, 20000, -1, 5, iLPassCutoffDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 470" + NL +
				
				
					"FLlabel 15,1,1" + NL +
				"iAmpScaleDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10,510" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkAmpScale, gihAmpScale		FLslider	\"Output Amplitude Rescaling\", 0, 10, 0, 5, iAmpScaleDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 510" + NL +
				
				";initialize values" + NL +
					"FLsetVal_i	0.1,	gihDelayTime" + NL +
					"FLsetVal_i	0.3,	gihDelayDWM" + NL +
					"FLsetVal_i	0,	gihDelayFB" + NL +
					";FLsetVal_i	0.0001,	gihCombRTime" + NL +
					";FLsetVal_i	0.0001,	gihCombLTime" + NL +
					";FLsetVal_i	1,	gihCombAScale" + NL +
					"FLsetVal_i	1,	gihDistPregain" + NL +
					"FLsetVal_i	0.4,	gihDistPostgain" + NL +
					"FLsetVal_i	0,	gihDistPShape" + NL +
					"FLsetVal_i	0,	gihDistNShape" + NL +
					"FLsetVal_i	0,	gihRMFreq" + NL +
					"FLsetVal_i	2000,	gihHPassCutoff" + NL +
					"FLsetVal_i	200,	gihLPassCutoff" + NL +
					"FLsetVal_i	1,	gihAmpScale" + NL +
				"	" + NL +
				
					"FLpanel_end" + NL +
				
					"FLrun" + NL +				
				
				"gaout		init	0" + NL +
				
				";instr 1 - main sound processor" + NL +
				"instr 		1	" + NL +
				"if		gkOnOff=1	goto	L1_CONTINUE" + NL +
						"turnoff" + NL +
				"L1_CONTINUE:" + NL +
				"#define		FILENAME	#\""+wavFile+"\"#" + NL +
				"ifilechnls	filenchnls	$FILENAME" + NL +
				"ifsr		filesr		$FILENAME" + NL +
				"if		ifilechnls = 1 then" + NL +
					"asig		diskin		$FILENAME,ifsr/sr,0,1" + NL +
				"else" + NL +
					"asig,aignore	diskin		$FILENAME,ifsr/sr,0,1" + NL +
				"endif" + NL +
				";asig,aignore	ins" + NL +
				"fsig  		pvsanal		asig,1024,256,1024,1" + NL +
				"fsigFrz		pvsfreeze	fsig,	gkAmpFrz,	gkFreqFrz" + NL +
				"fsigBlur	pvsblur		fsigFrz,	gkBlur,		3" + NL +
				"fsigSmth	pvsmooth	fsigBlur,	gkAmpSmth,	gkFreqSmth" + NL +
				"fScale		pvscale		fsigSmth,gkScale" + NL +
				"fShift		pvshift		fScale,gkShift, gkLowestShift" + NL +
				
				"kbin		oscili		gkLFODepth, gkLFOSpeed, 1" + NL +
				"kbin		=		kbin + gkLFOOffset" + NL +
				"kbin		limit		kbin, 0, 1" + NL +
				"fArp		pvsarp		fShift,kbin,gkArpDepth,gkArpGain" + NL +
				"gaout		pvsynth		fArp" + NL +
				";		outs		gaout,gaout" + NL +
				";gaout		=		0" + NL +
				"endin" + NL +
				
				
				";instr 2 - main panel's RESET button handller" + NL +
				"instr		2" + NL +
						"FLsetVal	1,	1,	gihScale" + NL +
						"FLsetVal	1,	0,	gihShift   " + NL +
						"FLsetVal	1,	0,	gihLowestShift" + NL +
						"FLsetVal	1,	0,	gihBothFrz" + NL +
						"FLsetVal	1,	0,	gihBlur" + NL +
						"FLsetVal	1,	1,	gihAmpSmth" + NL +
						"FLsetVal	1,	1,	gihFreqSmth" + NL +
						"FLsetVal	1,	0,	gihSmthLock" + NL +
						"FLsetVal	1,	0,	gihArpDepth" + NL +
						"FLsetVal	1,	0,	gihArpGain" + NL +
						"FLsetVal	1,	0,	gihLFODepth" + NL +
						"FLsetVal	1,	3,	gihLFOSpeed" + NL +
						"FLsetVal	1,	0,	gihLFOOffset" + NL +
						"turnoff" + NL +
				"endin" + NL +
				
				
				";instr 3 - FREEZE BOTH button hndller" + NL +
				"instr		3" + NL +
				"if		gkBothFrz = 0 	goto	L3_OFF" + NL +
						"FLsetVal	1,	1,	gihAmpFrz" + NL +
						"FLsetVal	1,	1,	gihFreqFrz" + NL +
						"turnoff" + NL +
				"L3_OFF:" + NL +
				"		FLsetVal	1,	0,	gihAmpFrz" + NL +
						"FLsetVal	1,	0,	gihFreqFrz" + NL +
						"turnoff" + NL +
				"endin" + NL +
				
				";instr 4 - LOCK SMOOTH FREQ AMP button handller" + NL +
				"instr		4" + NL +
				"if 		gkSmthLock = 1	goto	L4_ON" + NL +
						"turnoff" + NL +
				"L4_ON:" + NL +
				"		FLsetVal	1,	gkAmpSmth,gihFreqSmth" + NL +
				"endin" + NL +
				
				";instr 5 - DELAY filter" + NL +
				"instr		5" + NL +
				"if		gkDelayChk = 1	goto	L5_ON" + NL +
						"turnoff" + NL +
				"L5_ON:" + NL +
				"aFeedback	init	0" + NL +
				"aBuffer		delayr	5" + NL +
				"aDelaySig	deltap	gkDelayTime" + NL +
						"delayw	gaout+aFeedback" + NL +
				"aFeedback	=	aDelaySig*gkDelayFB" + NL +
				"atemp		=	(aDelaySig*gkDelayDWM)+(gaout*(1-gkDelayDWM))" + NL +
				"gaout		=	atemp" + NL +
				"endin" + NL +
				
				";instr 6 - COMB filter" + NL +
				";instr		6" + NL +
				";if		gkCombChk = 1 goto L6_ON" + NL +
				";		turnoff" + NL +
				";L6_ON:" + NL +
				";ares		comb	gaout,	gkCombRTime,	i(gkCombLTime);;atemp		=	ares*gkCombAScale" + NL +
				";;gaout		=	atemp" + NL +
				";gaout		=	ares" + NL +
				";endin" + NL +
				
				";instr 7 - DISTORT filter" + NL +
				"instr		7" + NL +
				"if		gkDistChk = 1 goto L7_ON" + NL +
						"turnoff" + NL +
				"L7_ON:" + NL +
				"atemp		distort1	gaout,	gkDistPregain, gkDistPostgain, gkDistPShape, gkDistNShape" + NL +
				"gaout		=	atemp" + NL +
				"endin" + NL +
				
				";instr 8 - filter panel's RESET button handller" + NL +
				"instr		8" + NL +
						"FLsetVal	1,	0,	gihDelayChk" + NL +
						"FLsetVal	1,	0.1,	gihDelayTime" + NL +
						"FLsetVal	1,	0.3,	gihDelayDWM" + NL +
						"FLsetVal	1,	0,	gihDelayFB" + NL +
						";FLsetVal_i	0.0001,	gihCombRTime" + NL +
						";FLsetVal_i	0.0001,	gihCombLTime" + NL +
						";FLsetVal_i	1,	gihCombAScale" + NL +
						"FLsetVal	1,	0,	gihDistChk" + NL +
						"FLsetVal	1,	1,	gihDistPregain" + NL +
						"FLsetVal	1,	0.4,	gihDistPostgain" + NL +
						"FLsetVal	1,	0,	gihDistPShape" + NL +
						"FLsetVal	1,	0,	gihDistNShape" + NL +
						"FLsetVal	1,	0,	gihRMChk" + NL +
						"FLsetVal	1,	0,	gihRMFreq" + NL +
						"FLsetVal	1,	0,	gihHPassChk" + NL +
						"FLsetVal	1,	0,	gihHPassDouble" + NL +
						"FLsetVal	1,	2000,	gihHPassCutoff" + NL +
						"FLsetVal	1,	0,	gihLPassChk" + NL +
						"FLsetVal	1,	0,	gihLPassDouble" + NL +
						"FLsetVal	1,	200,	gihLPassCutoff" + NL +
						"FLsetVal	1,	1,	gihAmpScale" + NL +
						"turnoff" + NL +
				"endin" + NL +
				
				";instr 9 - HIGH PASS filter" + NL +
				"instr		9" + NL +
				"if		gkHPassChk = 1 goto L9_ON" + NL +
						"turnoff" + NL +
				"L9_ON:" + NL +
				"aHP		atone	gaout,	gkHPassCutoff" + NL +
				"if		gkHPassDouble = 1 goto L9_DOUBLE" + NL +
				"aHP2		=	aHP" + NL +
						"goto	L9_CONTD" + NL +
				"L9_DOUBLE:" + NL +
				"aHP2		atone	aHP,	gkHPassCutoff" + NL +
				"L9_CONTD:" + NL +
				"gaout		=	aHP2" + NL +
				"endin" + NL +
				
				";instr 10 - LOW PASS filter" + NL +
				"instr		10" + NL +
				"if		gkLPassChk = 1 goto L10_ON" + NL +
						"turnoff" + NL +
				"L10_ON:" + NL +
				"aLP		tone	gaout,	gkLPassCutoff" + NL +
				"if		gkLPassDouble = 1 goto L10_DOUBLE" + NL +
				"aLP2		=	aLP" + NL +
						"goto	L10_CONTD" + NL +
				"L10_DOUBLE:" + NL +
				"aLP2		tone	aLP,	gkLPassCutoff" + NL +
				"L10_CONTD:" + NL +
				"gaout		=	aLP2" + NL +
				"endin" + NL +
				
				";instr 11 - RING MODULATION filter" + NL +
				"instr		11" + NL +
				"if		gkRMChk = 1 goto L11_ON" + NL +
						"turnoff" + NL +
				"L11_ON:" + NL +
				"aRM		oscili	gaout, gkRMFreq, 1" + NL +
				"gaout		=	aRM" + NL +
				"endin" + NL +
				
				
				";instr 99 - Final playout of the processed audio signal" + NL +
				"instr		99" + NL +
				"aout		=	gaout*gkAmpScale" + NL +
						"outs	aout,aout" + NL +
						"gaout = 0" + NL +
				"endin" + NL +
				"</CsInstruments>" + NL +
				
				
				
				"<CsScore>" + NL +
				"f 0 3600			;Dummy score event" + NL +
				"f 1 0 129 10 1			;SINE WAVE" + NL +
				"i 99 0 -1" + NL +
				"</CsScore>" + NL +
				"</CsoundSynthesizer>" + NL + NL;
	    	
	    	return csdString;
	    }
	    
	    public bool runLive(){
	    	
	    	ASCIIEncoding ascEnc = new ASCIIEncoding();			
			//byte[] bs = ascEnc.GetBytes(this.genLiveWavCSD(wavFile));
			byte[] bs = ascEnc.GetBytes(this.genLiveCSD());
			string tmp = Path.GetTempPath() + ".csd";
			
			try{
				FileStream fs = File.OpenWrite(tmp);
				fs.Write(bs,0,bs.Length);
				fs.Close();
			}catch(Exception ){
				return false;
			}
			
			Process p = null;
			
			try{				
				
				//p = Process.Start(this.csoundExe," -o \"" + outWav + "\"  \"" + tmp + "\"");
				p = Process.Start(this.csoundExe, " \"" + tmp + "\"");
			}catch(Exception){
				return false;
			}
			
			/*
			while(!p.HasExited){}
			
			if (p.ExitCode == 0){
				return true;
			}*/
		
	    	return true;
	    }
	    
	    public string genLiveCSD(){
	    	//wavFile = csoundPath(wavFile);
	    	string csdString = "<CsoundSynthesizer>" + NL +

				"<CsOptions>" + NL +
				"-idevaudio -odevaudio -b400" + NL +
				"</CsOptions>" + NL +
				
				"<CsInstruments>" + NL +
				
				"sr 		= 	44100" + NL +
				"kr 		= 	441" + NL +
				"ksmps 		= 	100" + NL +
				"nchnls 		= 	2" + NL +
				
				
				";Main panel" + NL +
				"iWinWidth	=	640" + NL +
				"iWinHeight	=	480" + NL +
				"iDisplayWidth	=	60" + NL +
				"iDisplayHeight	=	20" + NL +
				"iSliderWidth	=	iWinWidth - 30 - iDisplayWidth" + NL +
				"iSliderHeight	=	10" + NL +
					"FLpanel	\"Voice Changer --- Live\",   iWinWidth,     iWinHeight,    0,  0" + NL +
				
					"FLlabel		15, 2, 1" + NL +
				"gkOnOff,gihOnOff	FLbutton	\"On/Off\", 1, 0, 2, 100, 30, 10,            10, 0, 1, 0, -1" + NL +
				"gkReset,gihReset	FLbutton	\"Reset\",  1, 0, 1, 100, 30, iWinWidth-110, 10, 0, 2, 0,  1" + NL +
				
					"FLlabel		15, 1, 1" + NL +
				"iScaleDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 50" + NL +
				"iShiftDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 80" + NL +
				"iLowestShiftDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 110" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkScale,gihScale 	FLslider	\"Frequency Rescale\",         0.125,    8, -1, 5,       iScaleDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 50" + NL +
				"gkShift,gihShift 	FLslider	\"Frequency Shifting\",        -3000, 3000,  0, 5,       iShiftDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 80" + NL +
				"gkLowestShift,gihLowestShift FLslider	\"Lowest Frequency to Shift\", -3000, 3000,  0, 5, iLowestShiftDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 110" + NL +
				
					"FLlabel		15, 1, 1" + NL +
				"gkAmpFrz,gihAmpFrz	FLbutton	\"Freeze Amplitude\",                  1, 0, 2, 150, 30, 10,  150, 0, -1" + NL +
				"gkFreqFrz,gihFreqFrz	FLbutton	\"Freeze Frequency\",                  1, 0, 2, 150, 30, 170, 150, 0, -1" + NL +
				"gkBothFrz,gihBothFrz	FLbutton	\"Freeze Both Amplitude & Frequency\", 1, 0, 2, 300, 30, 330, 150, 0,  3, 0, 1" + NL +
				
				"iBlurDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				"	" + NL +
				"	FLlabel		15, 1, 3" + NL +
				"gkBlur,gihBlur		FLslider	\"Blurring Time\", 0, 3, 0, 5, iBlurDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 200" + NL +
				
				"iAmpSmthDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 240" + NL +
				"iFreqSmthDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 270" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkAmpSmth,gihAmpSmth	FLslider	\"Amplitude Smoothing Cutoff Frequency\", 0, 1, 0, 5,  iAmpSmthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 240" + NL +
				"gkFreqSmth,gihFreqSmth	FLslider	\"Frequency Smoothing Cutoff Frequency\", 0, 1, 0, 5, iFreqSmthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 270" + NL +
				
					"FLlabel		15, 1, 1" + NL +
				"gkSmthLock, gihSmthLock FLbutton	\"Smoothing Amplitude = Smoothing Frequency\", 1, 0, 3, 350, 30, 10, 290, 0, 4, 0, -1" + NL +
				
				"iArpDepthDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 330" + NL +
				"iArpGainDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 360" + NL +
				"iLFODepthDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 390" + NL +
				"iLFOSpeedDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 420" + NL +
				"iLFOOffsetDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 450" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkArpDepth,gihArpDepth		FLslider	\"Arpeggiate Depth\",                   0,    1,  0, 5,  iArpDepthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 330" + NL +
				"gkArpGain,gihArpGain		FLslider	\"Arpeggiate Gain Rescale\",            0,   10,  0, 5,   iArpGainDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 360" + NL +
				"gkLFODepth,gihLFODepth		FLslider	\"Low Frequency Oscillator Depth\",     0,  0.5,  0, 5,  iLFODepthDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 390" + NL +
				"gkLFOSpeed,gihLFOSpeed		FLslider	\"Low Frequency Oscillator Speed\", 0.001, 2000, -1, 5,  iLFOSpeedDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 420" + NL +
				"gkLFOOffset,gihLFOOffset	FLslider	\"Low Frequency Oscillator Offset\", -0.5,  0.5,  0, 5, iLFOOffsetDisplay, iSliderWidth, iSliderHeight, 20+iDisplayWidth, 450" + NL +
				
				";Initialize values" + NL +
					"FLsetVal_i	1, 	gihScale" + NL +
					"FLsetVal_i	0, 	gihShift   " + NL +
					"FLsetVal_i	0, 	gihLowestShift" + NL +
					"FLsetVal_i	0,	gihBlur" + NL +
					"FLsetVal_i	1,	gihAmpSmth" + NL +
					"FLsetVal_i	1,	gihFreqSmth" + NL +
					"FLsetVal_i	0, 	gihArpDepth" + NL +
					"FLsetVal_i	0, 	gihArpGain" + NL +
					"FLsetVal_i	0, 	gihLFODepth" + NL +
					"FLsetVal_i	3, 	gihLFOSpeed" + NL +
					"FLsetVal_i	0, 	gihLFOOffset" + NL +
				"          " + NL +
					"FLpanel_end" + NL +
				
				
				";Filter panel" + NL +
				"iWin2Width = 640" + NL +
				"iWin2Height = 550" + NL +
				"iSliderWidth2 = iWin2Width - 30 - iDisplayWidth" + NL +
				"iSliderHeight2 = 10" + NL +
					"FLpanel		\"Filter panel\", iWin2Width, iWin2Height, iWinWidth, 0" + NL +
				"	" + NL +
				"	FLlabel		15, 2, 1" + NL +
				
				"gkReset2,gihReset2	FLbutton	\"Reset\",  1, 0, 1, 100, 30, iWinWidth-110, 10, 0, 8, 0,  1" + NL +
				
				"gkDelayChk, gihDelayChk	FLbutton	\"Delay filter\", 1, 0, 3, 150, 30, 10, 10, 0, 5, 0, -1" + NL +
				
				"iDelayTimeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 40" + NL +
				"iDelayDWMDisplay	FLvalue 	\" \", iDisplayWidth, iDisplayHeight, 10, 70" + NL +
				"iDelayFBDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 100" + NL +
				
					"FLlabel		15, 1, 3" + NL +
				"gkDelayTime, gihDelayTime	FLslider	\"Delay Time\",        0, 5, 0, 5, iDelayTimeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 40" + NL +
				"gkDelayDWM, gihDelayDWM		FLslider	\"Delay Dry/Wet Mix\", 0, 1, 0, 5,  iDelayDWMDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 70" + NL +
				"gkDelayFB, gihDelayFB		FLslider	\"Delay Feedback Amount\", -0.95, 0.95, 0, 5,  iDelayFBDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 100" + NL +
				
					"FLlabel		15, 2, 1" + NL +
				";gkCombChk, gihCombChk	FLbutton	\"Comb filter\", 1, 0, 3, 150, 30, 10, 140, 0, 6, 0, -1" + NL +
				
				";iCombRTimeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 170" + NL +
				";iCombLTimeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				";iCombAScaleDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				
					"FLlabel 15,1,3" + NL +
				";gkCombRTime, gihCombRTime	FLslider	\"Comb Reverb Time\",              0.0001,  10, -1, 5,  iCombRTimeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 170" + NL +
				";gkCombLTime, gihCombLTime	FLslider	\"Comb Loop Time\",                0.0001, 0.1, -1, 5,  iCombLTimeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 200" + NL +
				";gkCombAScale, gihCombAScale	FLslider	\"Comb Output Amplitude Scaling\",      0,   1,  0, 5, iCombAScaleDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 200" + NL +
				
					"FLlabel 15,2,1" + NL +
				"gkDistChk, gihDistChk	FLbutton	\"Distort filter\", 1, 0, 3, 150, 30, 10, 140, 0, 7, 0, -1" + NL +
				
				"iDistPregainDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 170" + NL +
				"iDistPostgainDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 200" + NL +
				"iDistPShapeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10 ,230" + NL +
				"iDistNShapeDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 260" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkDistPregain, gihDistPregain	FLslider	\"Pregain\",                       0, 100,  0, 5,  iDistPregainDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 170" + NL +
				"gkDistPostgain,gihDistPostgain	FLslider	\"Postgain\",                  0.001,   1, -1, 5, iDistPostgainDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 200" + NL +
				"gkDistPShape,  gihDistPShape	FLslider	\"Shape for Positive Signal\",     0,   1,  0, 5,   iDistPShapeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 230" + NL +
				"gkDistNShape,  gihDistNShape	FLslider	\"Shape for Negative Signal\",     0,   1,  0, 5,   iDistNShapeDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 260" + NL +
				
					"FLlabel	15,2,1" + NL +
				"gkRMChk, gihRMChk		FLbutton	\"Ring Modulation\", 1, 0, 3, 150, 30, 10, 300, 0, 11, 0, -1" + NL +
				";iRMAmpDisplay			FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 330" + NL +
				"iRMFreqDisplay			FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 330" + NL +
				
					"FLlabel	15,1,3" + NL +
				";gkRMAmp, gihRMAmp		FLslider	\"Sine wave Amplitude\", 0, 100, 0, 5,  iRMAmpDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 330" + NL +
				"gkRMFreq, gihRMFreq		FLslider	\"Sine wave Frequency\", 0.1,  100, 0, 5, iRMFreqDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 330" + NL +
				
					"FLlabel 15,2,1" + NL +
				"gkHPassChk, gihHPassChk		FLbutton	\"High Pass Filter\", 1, 0, 3, 150, 30, 10,  370, 0,   9, 0, -1" + NL +
				"gkHPassDouble, gihHPassDouble	FLbutton	\"Double filtering\", 1, 0, 3, 150, 30, 170, 370, 0,  -1" + NL +
				"iHPassCutoffDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 400" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkHPassCutoff, gihHPassCutoff	FLslider	\"High Pass Cutoff Frequency\", 20, 20000, -1, 5, iHPassCutoffDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 400" + NL +
				
					"FLlabel 15,2,1" + NL +
				"gkLPassChk, gihLPassChk		FLbutton	\"Low Pass Filter\", 1, 0, 3, 150, 30, 10,  440, 0,   10, 0, -1" + NL +
				"gkLPassDouble, gihLPassDouble	FLbutton	\"Double filtering\", 1, 0, 3, 150, 30, 170, 440, 0,  -1" + NL +
				"iLPassCutoffDisplay		FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10, 470" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkLPassCutoff, gihLPassCutoff	FLslider	\"Low Pass Cutoff Frequency\", 20, 20000, -1, 5, iLPassCutoffDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 470" + NL +
				
				
					"FLlabel 15,1,1" + NL +
				"iAmpScaleDisplay	FLvalue		\" \", iDisplayWidth, iDisplayHeight, 10,510" + NL +
				
					"FLlabel 15,1,3" + NL +
				"gkAmpScale, gihAmpScale		FLslider	\"Output Amplitude Rescaling\", 0, 10, 0, 5, iAmpScaleDisplay, iSliderWidth2, iSliderHeight2, 20+iDisplayWidth, 510" + NL +
				
				";initialize values" + NL +
					"FLsetVal_i	0.1,	gihDelayTime" + NL +
					"FLsetVal_i	0.3,	gihDelayDWM" + NL +
					"FLsetVal_i	0,	gihDelayFB" + NL +
					";FLsetVal_i	0.0001,	gihCombRTime" + NL +
					";FLsetVal_i	0.0001,	gihCombLTime" + NL +
					";FLsetVal_i	1,	gihCombAScale" + NL +
					"FLsetVal_i	1,	gihDistPregain" + NL +
					"FLsetVal_i	0.4,	gihDistPostgain" + NL +
					"FLsetVal_i	0,	gihDistPShape" + NL +
					"FLsetVal_i	0,	gihDistNShape" + NL +
					"FLsetVal_i	0,	gihRMFreq" + NL +
					"FLsetVal_i	2000,	gihHPassCutoff" + NL +
					"FLsetVal_i	200,	gihLPassCutoff" + NL +
					"FLsetVal_i	1,	gihAmpScale" + NL +
				"	" + NL +
				
					"FLpanel_end" + NL +
				
					"FLrun" + NL +				
				
				"gaout		init	0" + NL +
				
				";instr 1 - main sound processor" + NL +
				"instr 		1	" + NL +
				"if		gkOnOff=1	goto	L1_CONTINUE" + NL +
						"turnoff" + NL +
				"L1_CONTINUE:" + NL +

				"asig,aignore	ins" + NL +
				"fsig  		pvsanal		asig,1024,256,1024,1" + NL +
				"fsigFrz		pvsfreeze	fsig,	gkAmpFrz,	gkFreqFrz" + NL +
				"fsigBlur	pvsblur		fsigFrz,	gkBlur,		3" + NL +
				"fsigSmth	pvsmooth	fsigBlur,	gkAmpSmth,	gkFreqSmth" + NL +
				"fScale		pvscale		fsigSmth,gkScale" + NL +
				"fShift		pvshift		fScale,gkShift, gkLowestShift" + NL +
				
				"kbin		oscili		gkLFODepth, gkLFOSpeed, 1" + NL +
				"kbin		=		kbin + gkLFOOffset" + NL +
				"kbin		limit		kbin, 0, 1" + NL +
				"fArp		pvsarp		fShift,kbin,gkArpDepth,gkArpGain" + NL +
				"gaout		pvsynth		fArp" + NL +
				";		outs		gaout,gaout" + NL +
				";gaout		=		0" + NL +
				"endin" + NL +
				
				
				";instr 2 - main panel's RESET button handller" + NL +
				"instr		2" + NL +
						"FLsetVal	1,	1,	gihScale" + NL +
						"FLsetVal	1,	0,	gihShift   " + NL +
						"FLsetVal	1,	0,	gihLowestShift" + NL +
						"FLsetVal	1,	0,	gihBothFrz" + NL +
						"FLsetVal	1,	0,	gihBlur" + NL +
						"FLsetVal	1,	1,	gihAmpSmth" + NL +
						"FLsetVal	1,	1,	gihFreqSmth" + NL +
						"FLsetVal	1,	0,	gihSmthLock" + NL +
						"FLsetVal	1,	0,	gihArpDepth" + NL +
						"FLsetVal	1,	0,	gihArpGain" + NL +
						"FLsetVal	1,	0,	gihLFODepth" + NL +
						"FLsetVal	1,	3,	gihLFOSpeed" + NL +
						"FLsetVal	1,	0,	gihLFOOffset" + NL +
						"turnoff" + NL +
				"endin" + NL +
				
				
				";instr 3 - FREEZE BOTH button hndller" + NL +
				"instr		3" + NL +
				"if		gkBothFrz = 0 	goto	L3_OFF" + NL +
						"FLsetVal	1,	1,	gihAmpFrz" + NL +
						"FLsetVal	1,	1,	gihFreqFrz" + NL +
						"turnoff" + NL +
				"L3_OFF:" + NL +
				"		FLsetVal	1,	0,	gihAmpFrz" + NL +
						"FLsetVal	1,	0,	gihFreqFrz" + NL +
						"turnoff" + NL +
				"endin" + NL +
				
				";instr 4 - LOCK SMOOTH FREQ AMP button handller" + NL +
				"instr		4" + NL +
				"if 		gkSmthLock = 1	goto	L4_ON" + NL +
						"turnoff" + NL +
				"L4_ON:" + NL +
				"		FLsetVal	1,	gkAmpSmth,gihFreqSmth" + NL +
				"endin" + NL +
				
				";instr 5 - DELAY filter" + NL +
				"instr		5" + NL +
				"if		gkDelayChk = 1	goto	L5_ON" + NL +
						"turnoff" + NL +
				"L5_ON:" + NL +
				"aFeedback	init	0" + NL +
				"aBuffer		delayr	5" + NL +
				"aDelaySig	deltap	gkDelayTime" + NL +
						"delayw	gaout+aFeedback" + NL +
				"aFeedback	=	aDelaySig*gkDelayFB" + NL +
				"atemp		=	(aDelaySig*gkDelayDWM)+(gaout*(1-gkDelayDWM))" + NL +
				"gaout		=	atemp" + NL +
				"endin" + NL +
				
				";instr 6 - COMB filter" + NL +
				";instr		6" + NL +
				";if		gkCombChk = 1 goto L6_ON" + NL +
				";		turnoff" + NL +
				";L6_ON:" + NL +
				";ares		comb	gaout,	gkCombRTime,	i(gkCombLTime);;atemp		=	ares*gkCombAScale" + NL +
				";;gaout		=	atemp" + NL +
				";gaout		=	ares" + NL +
				";endin" + NL +
				
				";instr 7 - DISTORT filter" + NL +
				"instr		7" + NL +
				"if		gkDistChk = 1 goto L7_ON" + NL +
						"turnoff" + NL +
				"L7_ON:" + NL +
				"atemp		distort1	gaout,	gkDistPregain, gkDistPostgain, gkDistPShape, gkDistNShape" + NL +
				"gaout		=	atemp" + NL +
				"endin" + NL +
				
				";instr 8 - filter panel's RESET button handller" + NL +
				"instr		8" + NL +
						"FLsetVal	1,	0,	gihDelayChk" + NL +
						"FLsetVal	1,	0.1,	gihDelayTime" + NL +
						"FLsetVal	1,	0.3,	gihDelayDWM" + NL +
						"FLsetVal	1,	0,	gihDelayFB" + NL +
						";FLsetVal_i	0.0001,	gihCombRTime" + NL +
						";FLsetVal_i	0.0001,	gihCombLTime" + NL +
						";FLsetVal_i	1,	gihCombAScale" + NL +
						"FLsetVal	1,	0,	gihDistChk" + NL +
						"FLsetVal	1,	1,	gihDistPregain" + NL +
						"FLsetVal	1,	0.4,	gihDistPostgain" + NL +
						"FLsetVal	1,	0,	gihDistPShape" + NL +
						"FLsetVal	1,	0,	gihDistNShape" + NL +
						"FLsetVal	1,	0,	gihRMChk" + NL +
						"FLsetVal	1,	0,	gihRMFreq" + NL +
						"FLsetVal	1,	0,	gihHPassChk" + NL +
						"FLsetVal	1,	0,	gihHPassDouble" + NL +
						"FLsetVal	1,	2000,	gihHPassCutoff" + NL +
						"FLsetVal	1,	0,	gihLPassChk" + NL +
						"FLsetVal	1,	0,	gihLPassDouble" + NL +
						"FLsetVal	1,	200,	gihLPassCutoff" + NL +
						"FLsetVal	1,	1,	gihAmpScale" + NL +
						"turnoff" + NL +
				"endin" + NL +
				
				";instr 9 - HIGH PASS filter" + NL +
				"instr		9" + NL +
				"if		gkHPassChk = 1 goto L9_ON" + NL +
						"turnoff" + NL +
				"L9_ON:" + NL +
				"aHP		atone	gaout,	gkHPassCutoff" + NL +
				"if		gkHPassDouble = 1 goto L9_DOUBLE" + NL +
				"aHP2		=	aHP" + NL +
						"goto	L9_CONTD" + NL +
				"L9_DOUBLE:" + NL +
				"aHP2		atone	aHP,	gkHPassCutoff" + NL +
				"L9_CONTD:" + NL +
				"gaout		=	aHP2" + NL +
				"endin" + NL +
				
				";instr 10 - LOW PASS filter" + NL +
				"instr		10" + NL +
				"if		gkLPassChk = 1 goto L10_ON" + NL +
						"turnoff" + NL +
				"L10_ON:" + NL +
				"aLP		tone	gaout,	gkLPassCutoff" + NL +
				"if		gkLPassDouble = 1 goto L10_DOUBLE" + NL +
				"aLP2		=	aLP" + NL +
						"goto	L10_CONTD" + NL +
				"L10_DOUBLE:" + NL +
				"aLP2		tone	aLP,	gkLPassCutoff" + NL +
				"L10_CONTD:" + NL +
				"gaout		=	aLP2" + NL +
				"endin" + NL +
				
				";instr 11 - RING MODULATION filter" + NL +
				"instr		11" + NL +
				"if		gkRMChk = 1 goto L11_ON" + NL +
						"turnoff" + NL +
				"L11_ON:" + NL +
				"aRM		oscili	gaout, gkRMFreq, 1" + NL +
				"gaout		=	aRM" + NL +
				"endin" + NL +
				
				
				";instr 99 - Final playout of the processed audio signal" + NL +
				"instr		99" + NL +
				"aout		=	gaout*gkAmpScale" + NL +
						"outs	aout,aout" + NL +
						"gaout = 0" + NL +
				"endin" + NL +
				"</CsInstruments>" + NL +
				
				
				
				"<CsScore>" + NL +
				"f 0 3600			;Dummy score event" + NL +
				"f 1 0 129 10 1			;SINE WAVE" + NL +
				"i 99 0 -1" + NL +
				"</CsScore>" + NL +
				"</CsoundSynthesizer>" + NL + NL;
	    	
	    	return csdString;
	    } 
	    
	    // run file-2-file -- final version
	    public bool runWavFile(){    	
			
			ASCIIEncoding ascEnc = new ASCIIEncoding();			
			byte[] bs = ascEnc.GetBytes(this.genWavFileCSD(inWav));
			string tmp = Path.GetTempPath() + ".csd";
			//tmp = ""
			try{
				FileStream fs = File.OpenWrite(tmp);
				fs.Write(bs,0,bs.Length);
				fs.Close();
			}catch(Exception ){
				return false;
			}
			
			Process p = null;
			
			try{				
				
				p = Process.Start(this.csoundExe," -o \"" + outWav + "\"  \"" + tmp + "\"");
				//p = Process.Start(this.csoundExe, " \"" + tmp + "\"");
			}catch(Exception ){
				return false;
			}
				
			while(!p.HasExited){}
			
			if (p.ExitCode == 0){
				return true;
			}
			
			return false;
		}
	    
	    /*
	     * gen CSD file : WAV to WAV
	     * */
	    public string genWavFileCSD(string wavFile){
	    	
	    	wavFile = Csound.csoundPath(wavFile);

				
			string gkDelayTime = this.delayTime.ToString();
			
			string wavDur = this.destLength.ToString(); 	
	    	
	    	
	    	string csdString = "<CsoundSynthesizer>" + NL +

				"<CsOptions>" + NL +
				"-b400" + NL +
				"</CsOptions>" + NL +
				
				"<CsInstruments>" + NL +
				
				"sr 		= 	44100" + NL +
				"kr 		= 	441" + NL +
				"ksmps 		= 	100" + NL +
				"nchnls 		= 	2" + NL +
				
	    		// input WAV file
				"#define		FILENAME	#\""+wavFile+"\"#" + NL +
				
				// define values
				
	    		"#define gkScale #"+this.feqScale.ToString()+"#" + NL +
	    		"#define gkShift #"+this.feqShift.ToString()+"#" + NL +
	    		"#define gkLowestShift #"+this.feqShiftLow.ToString()+"#" + NL +
				
				"#define gkAmpFrz #0# ; 0" + NL +
				"#define gkFreqFrz #0# ; 0" + NL +
				
	    		"#define gkBlur #"+this.blurTime.ToString()+"#" + NL +
	    		"#define gkAmpSmth #"+this.ampCF.ToString()+"#" + NL +
	    		"#define gkFreqSmth #"+this.feqCF.ToString()+"#" + NL +
				
	    		"#define gkArpDepth #"+this.arpDepth.ToString()+"#" + NL +
	    		"#define gkArpGain #"+this.arpGain.ToString()+"#" + NL +
	    		"#define gkLFODepth #"+this.lfoDepth.ToString()+"#" + NL +
	    		"#define gkLFOSpeed #"+this.lfoSpeed.ToString()+"#" + NL +
	    		"#define gkLFOOffset #"+this.lfoOffset.ToString()+"#" + NL +
				
				
				
	    		"#define gkDelayChk #"+b2s(this.bDelay)+"#" + NL +
				"#define gkDelayTime #"+this.delayTime.ToString()+"#" + NL +
	    		"#define gkDelayFB #"+this.delayFB.ToString()+"#" + NL +
	    		"#define gkDelayDWM #"+this.delayDWM.ToString()+"#" + NL +
				
				"#define gkDistChk #"+b2s(this.bDistort)+"#" + NL +
	    		"#define gkDistPregain #"+this.distPregain.ToString()+"#" + NL +
	    		"#define gkDistPostgain #"+this.distPostgain.ToString()+"#" + NL +
	    		"#define gkDistPShape #"+this.distPS.ToString()+"#" + NL +
	    		"#define gkDistNShape #"+this.distNS.ToString()+"#" + NL +
	    		
	    		
				
				"#define gkHPassChk #"+b2s(this.bHP)+"#" + NL +
				"#define gkHPassDouble #"+b2s(this.bHPd)+"#" + NL +
	    		"#define gkHPassCutoff #"+this.hpco.ToString()+"#" + NL +
				
				
				"#define gkLPassChk #"+b2s(this.bLP)+"#" + NL +
				"#define gkLPassDouble #"+b2s(this.bLPd)+"#" + NL +
	    		"#define gkLPassCutoff #"+this.lpco.ToString()+"#" + NL +
				
				"#define gkRMChk #"+b2s(this.bRing)+"#" + NL +
	    		"#define gkRMFreq #"+this.ringco.ToString()+"#" + NL +
				
	    		"#define gkAmpScale #"+this.ampScale.ToString()+"#" + NL +
				
	    		// csound start
				
				"gaout		init	0" + NL +
				
	    		// main sound
				";instr 1 - main sound processor" + NL +
				"instr 		1	" + NL +
				
				"ifilechnls	filenchnls	$FILENAME" + NL +
				"ifsr		filesr		$FILENAME" + NL +
				"if		ifilechnls = 1 then" + NL +
					"asig		diskin		$FILENAME,ifsr/sr,0,1" + NL +
					";asig		diskin		$FILENAME,1,0,1" + NL +
				"else" + NL +
					"asig,aignore	diskin		$FILENAME,ifsr/sr,0,1" + NL +
				"endif" + NL +
				
				"fsig  		pvsanal		asig,1024,256,1024,1" + NL +
				"fsigFrz		pvsfreeze	fsig, $gkAmpFrz, $gkFreqFrz" + NL +
				"fsigBlur	pvsblur		fsigFrz, $gkBlur,		3" + NL +
				"fsigSmth	pvsmooth	fsigBlur, $gkAmpSmth, $gkFreqSmth" + NL +
				"fScale		pvscale		fsigSmth, $gkScale" + NL +
				"fShift		pvshift		fScale, $gkShift, $gkLowestShift" + NL +
				
				"kbin		oscili	 $gkLFODepth, $gkLFOSpeed, 1" + NL +
				"kbin		=		kbin + $gkLFOOffset" + NL +
				"kbin		limit		kbin, 0, 1" + NL +
				"fArp		pvsarp		fShift,kbin, $gkArpDepth, $gkArpGain" + NL +
				"gaout		pvsynth		fArp" + NL +
				
				"endin" + NL ;
				
	    		
				// Delay filter
				
				csdString += "instr		2" + NL +
				"if	 $gkDelayChk = 1	goto	L5_ON" + NL +
						"turnoff" + NL +
				"L5_ON:" + NL +
				"aFeedback	init	0" + NL +
				"aBuffer		delayr	5" + NL +
				"aDelaySig	deltap $gkDelayTime" + NL +
						"delayw	gaout+aFeedback" + NL +
				"aFeedback	=	aDelaySig*$gkDelayFB" + NL +
				"atemp		=	(aDelaySig*$gkDelayDWM)+(gaout*(1-$gkDelayDWM))" + NL +
				"gaout		=	atemp" + NL +
				"endin" + NL ;
				
				
				
				// Distort filter			
				
				csdString += "instr		3" + NL +
				"if		$gkDistChk = 1 goto L7_ON" + NL +
						"turnoff" + NL +
				"L7_ON:" + NL +
				"atemp		distort1	gaout, $gkDistPregain, $gkDistPostgain, $gkDistPShape, $gkDistNShape" + NL +
				"gaout		=	atemp" + NL +
				"endin" + NL ;
				
				// High pass filter				
				
				csdString += "instr		4" + NL +
				"if	 $gkHPassChk = 1 goto L9_ON" + NL +
						"turnoff" + NL +
				"L9_ON:" + NL +
				"aHP		atone	gaout, $gkHPassCutoff" + NL +
				"if	 $gkHPassDouble = 1 goto L9_DOUBLE" + NL +
				"aHP2		=	aHP" + NL +
						"goto	L9_CONTD" + NL +
				"L9_DOUBLE:" + NL +
				"aHP2		atone	aHP, $gkHPassCutoff" + NL +
				"L9_CONTD:" + NL +
				"gaout		=	aHP2" + NL +
				"endin" + NL ;
				
	    		// Low pass filter				
	    		
				csdString += "instr		5" + NL +

				"aLP		tone	gaout, $gkLPassCutoff" + NL +
				"if	 $gkLPassDouble = 1 goto L10_DOUBLE" + NL +
				"aLP2		=	aLP" + NL +
						"goto	L10_CONTD" + NL +
				"L10_DOUBLE:" + NL +
				"aLP2		tone	aLP, $gkLPassCutoff" + NL +
				"L10_CONTD:" + NL +
				"gaout		=	aLP2" + NL +
				"endin" + NL ;
	    		
				
	    		// Ring Mod				
	    		
				csdString += "instr		6" + NL +
				"if	 $gkRMChk = 1 goto L11_ON" + NL +
						"turnoff" + NL +
				"L11_ON:" + NL +
				"aRM		oscili	gaout, $gkRMFreq, 1" + NL +
				"gaout		=	aRM" + NL +
				"endin" + NL ;
				
				
	    		// Final Output	    		
				csdString += ";instr 99 - Final playout of the processed audio signal" + NL +
				"instr		99" + NL +
				"aout		=	gaout*$gkAmpScale" + NL +
						"outs	aout,aout" + NL +
						"gaout = 0" + NL +
				"endin" + NL +
				"</CsInstruments>" + NL +
				
				"<CsScore>" + NL +
				
				"f 0 "+ wavDur  +"			;Dummy score event" + NL +
				"f 1 0 129 10 1			;SINE WAVE" + NL +
	    		
				"i 99 0 -1" + NL +
				"i 1 0 -1" + NL ;
				
				if(this.bDelay)
					csdString += "i 2 0 -1" + NL ;
				if(this.bDistort)
					csdString += "i 3 0 -1" + NL ;
				if(this.bHP)
					csdString += "i 4 0 -1" + NL ;
				if(this.bLP)
					csdString += "i 5 0 -1" + NL ;				
				if(this.bRing)
					csdString += "i 6 0 -1" + NL ;
				
				csdString += "</CsScore>" + NL + "</CsoundSynthesizer>" + NL + NL;
	    	
	    	
	    	return csdString;

	    }
	    
	}
	
	
	    
	    
	    
}

	

