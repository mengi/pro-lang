import java.text.SimpleDateFormat;
import java.util.Date;
class Kisi {
		String Ad, Soyad;
		String Tc, DogumTarihi; 
		char Cinsiyet;
		
		public Kisi(String gelenAd, String gelenSoyad, String gelenTc, char gelenCinsiyet, String gelenDogumTarihi){
			this.nameSet(gelenAd);
			this.lastnameSet(gelenSoyad);
			this.tcSet(gelenTc);
			this.cinsiyetSet(gelenCinsiyet);
			this.DogumTarihiSet(gelenDogumTarihi);
		}
		
		public void cinsiyetSet(char new_cinsiyet){
			if (new_cinsiyet !='E' && new_cinsiyet != 'K') {
				System.out.println("Yanliþ giriþ yaptiniz ERKEK'se E'yi veya KÝZ'sa K'yi giriniz.");
			}else {
				this.Cinsiyet = new_cinsiyet;
			}
		}
		public char cinsiyetGet(){
			return this.Cinsiyet;
		}
		public void DogumTarihiSet(String Dogum_Tarihi){
			if(Dogum_Tarihi.length() != 4){
				System.out.println("Dogum yýlýný giriniz");
			}else{
				Date Bugun = new Date();
				SimpleDateFormat Format = new SimpleDateFormat("yyyy");
				String yýl = Format.format(Bugun);
				int yas = Integer.parseInt(yýl) - Integer.parseInt(Dogum_Tarihi);
				this.DogumTarihi = Integer.toString(yas);
			}
		}
		public String DogumTarihiGet(){
			return this.DogumTarihi;
		}
		private void tcSet(String new_Tc){
			if (new_Tc.length() != 11) {
				System.out.println("11 haneli TC Numarasýný giriniz.");
			}else {
				this.Tc = new_Tc; 
			}
		}
		public String tcGet(){
			return this.Tc;
		}
		
		public void nameSet(String new_firstname){
			this.Ad = new_firstname;
		}
		
		public String nameGet(){
			return this.Ad;
		}
		
		public void lastnameSet(String new_lastname){
			this.Soyad = new_lastname;
		}
		
		public String lastnameGet(){
			return this.Soyad;
		}
		
		public String Kisi_Tostring(){
			String str = "";
			str+= "\n Kisi Bilgileri\n----------------";
			str+= "\n Ad: " +this.nameGet()+"\n";
			str+= "\n Soyad: " +this.lastnameGet()+"\n";
			str+= "\n Cinsyet: " +this.cinsiyetGet()+"\n";
			str+= "\n T.C. Numarasi: " +this.tcGet()+"\n";
			str+= "\n Yas: " + this.DogumTarihiGet()+"\n";
			return str;
		}

}
