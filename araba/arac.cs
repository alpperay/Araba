namespace araba;

public class arac{
string marka,model,yakitTipi,renk,sanziman,saseNo;
int yil,fiyat;

public string Marka
{get{return marka;}
 /*set{marka=value;}*/}

public string Model
{get{return model;}
 /*set{model=value;}*/}

public string YakitTipi
{get{return yakitTipi;}
 set{yakitTipi=value;}}

public string Renk
{get{return renk;}
 set{renk=value;}}

public string Sanziman
{get{return sanziman;}
 set{sanziman=value;}}

public string SaseNo
{get{return saseNo;}
 /*set{saseNo=value;}*/}
 
public int Yil
{get{return yil;}
/*set{yil=value;}*/}

public int Fiyat
{get{return fiyat;}
 set{fiyat=value;}}



public arac(string marka,string model,string yakitTipi,string renk,string sanziman,string saseNo,int yil,int fiyat)
{this.marka=marka;
this.model=model;
YakitTipi=yakitTipi;
Renk=renk;
Sanziman=sanziman;
this.saseNo=saseNo;
this.yil=yil;
Fiyat=fiyat;}

public void  FiyatGuncelle(int yenifiyat)
{Fiyat=yenifiyat;
 Console.WriteLine("fiyat guncellendi");}

public void Ozellikler()
{Console.WriteLine("Marka="+Marka+" Model="+Model+" Yakıt Tipi="+YakitTipi+" Renk="+Renk+" Şanzıman="+Sanziman+" şaşe no="+SaseNo+" yıl="+Yil+" Fiyat="+Fiyat);}


}
