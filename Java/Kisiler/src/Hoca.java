
class Hoca extends Kisi {
	private String SicilNo;
	String BolumH, Unvan;
	public Hoca(String gelenAd, String gelenSoyad, String gelenTc,
			char gelenCinsiyet, String gelenDogumTarihi,String gelenBolumH, 
			String gelenUnvan, String gelenSicilNo) {
		super(gelenAd, gelenSoyad, gelenTc, gelenCinsiyet, gelenDogumTarihi);
		this.BolumHSet(gelenBolumH);
		this.UnvanSet(gelenUnvan);
		this.SicilNoSet(gelenSicilNo);
		this.Gorev_Goster();
		// TODO Auto-generated constructor stub
	}
	public void SicilNoSet(String Sicil_No){
		if (Sicil_No.length() != 11) {
			System.out.println("11 haneli Sicil Numarasini giriniz.");
		}else {
			this.SicilNo = Sicil_No; 
		}
	}

	private String SicilNoGet(){
		return this.SicilNo;
	}
	public void UnvanSet(String Unvan_ad){
		this.Unvan = Unvan_ad;
	}
	public String UnvanGet(){
		return this.Unvan;
	}
	public void BolumHSet(String Bolum_ad){
		this.BolumH = Bolum_ad;
	}
	public String BolumHGet(){
		return this.BolumH;
	}
	
	private void Gorev_Goster(){
		System.out.println("\n Hoca Gorevleri ve Bilgileri \n-----------------------------");
		System.out.println("Hoca derse girer ve ders anlatir...");
		System.out.println("Hoca sinav yapar...");
	}
	public String Hoca_ToString(){
		String str = super.Kisi_Tostring();
		str+= "\n Hoca Durum Bilgisi \n--------------------";
		str+= "\n Sicil Numarasi: " + this.SicilNoGet() +"\n";
		str+= "\n Bölüm Adi : " + this.BolumHGet() +"\n";
		str+= "\n Ünvan : " + this.UnvanGet() + "\n";
		return str;
	}
		
}


