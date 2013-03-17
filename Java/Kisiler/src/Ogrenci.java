
class Ogrenci extends Kisi{
	String Ogrenci_no, Bolum, Sinif_bilgisi;
	public Ogrenci(String gelenAd, String gelenSoyad, 
			String gelenTc, char gelenCinsiyet, String gelenDogumTarihi,
			String gelenOgrenci_no, String gelenBolum, String gelenSinif_bilgisi) {
		
		super(gelenAd, gelenSoyad, gelenTc, gelenCinsiyet, gelenDogumTarihi);
		this.Ogrenci_noSet(gelenOgrenci_no);
		this.BolumSet(gelenBolum);
		this.Sinif_BilgisiSet(gelenSinif_bilgisi);
		this.Ogrenci_Gorev();

		// TODO Auto-generated constructor stub
	}
	public void Ogrenci_noSet(String namber){
		this.Ogrenci_no = namber;
	}
	public String Ogrenci_noGet(){
		return this.Ogrenci_no;
	}
	public void BolumSet(String Bolum_ad){
		this.Bolum = Bolum_ad;
	}
	public String BolumGet(){
		return this.Bolum;
	}
	public void Sinif_BilgisiSet(String Sinif_bil){
		this.Sinif_bilgisi = Sinif_bil;
	}
	public String sinif_BilgisiGet(){
		return this.Sinif_bilgisi;
	}
	public void Ogrenci_Gorev(){
		System.out.println("\n Ogrenci Gorevleri ve Bilgileri\n--------------------------------");
		System.out.println("Ogrenci derse girer ...");
		System.out.println("Ogrenci kantine gider ...");
	}
	
	public String Ogrenci_Tostring(){
		String str = super.Kisi_Tostring();
		str+=" \n Ogrenci Durum Bilgisi \n-----------------------";
		str+=" \nOgrenci Numarasi: " + this.Ogrenci_noGet() + "\n";
		str+=" \nBolum Adi: " + this.BolumGet() + "\n";
		str+=" \nSinif: " + this.sinif_BilgisiGet()+".Sinif Ogrencisi \n";
		return str;
	}
	
}
