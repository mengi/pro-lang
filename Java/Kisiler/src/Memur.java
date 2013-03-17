
class Memur extends Kisi{
	String SicilNamber,Calistigi_Birim;
	public Memur(String gelenAd, String gelenSoyad, String gelenTc,
			char gelenCinsiyet,  String gelenDogumTarihi,
			String gelenSicilNamber, String gelenCalistigi_Birim) {
		super(gelenAd, gelenSoyad, gelenTc, gelenCinsiyet, gelenDogumTarihi);
		this.SicilNamberSet(gelenSicilNamber);
		this.Calistigi_birimSet(gelenCalistigi_Birim);
		this.Memur_Gorev();
		// TODO Auto-generated constructor stub
	}
	public void SicilNamberSet(String Sicil_Namber){
		this.SicilNamber = Sicil_Namber; 
	}
	public String SicilNamberGet(){
		return this.SicilNamber;
	}
	public void Calistigi_birimSet(String Calis_Birim){
		this.Calistigi_Birim = Calis_Birim;
	}
	public String Calistigi_BirimGet(){
		return this.Calistigi_Birim;
	}
	public void Memur_Gorev(){
		System.out.println("\n Memur Gorevleri ve Bilgileri \n------------------------------");
		System.out.println("Memur Evrak getir, gotur ...");
	}
	public String Memur_TosString(){
		String str = super.Kisi_Tostring();
		str+= "\n Memur Durum Bilgisi \n---------------------";
		str+="\n Sicil Numarasi: " + this.SicilNamber + "\n";
		str+="\n Çaliþtiði birim: " + this.Calistigi_Birim + "\n";
		return str;
	}
}
	

