class KisiDeneme {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Ogrenci o1 = new Ogrenci("Muhammet", "Enginar", "35135434532", 
				'E', "1993", "10060294", "BiyoGenetik", "3");
		System.out.println(o1.Ogrenci_Tostring());
		
		Hoca h1 = new Hoca("Mehmet", "Civelek", "45621345632", 'E', "1965", "Biligisayar Mühendisligi", "Yrd. Doç.", "12365234545");
		System.out.println(h1.Hoca_ToString());
		
		Memur m1 = new Memur("Ali", "Yarim", "98656213456", 'E',"1965", "78845621302", "Ögrenci Ýþleri");
		System.out.println(m1.Memur_TosString());
		System.exit(0);
	}

}

