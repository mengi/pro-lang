import java.util.Scanner;
public class Hello {
	public 	static void main(String args[]){
		@SuppressWarnings("resource")
		Scanner scan = new Scanner(System.in);
		int secenek,sayi1, sayi2;
		boolean calisir;
		calisir = true;
		System.out.print("Ýlk sayiyi giriniz:" );
		sayi1 = scan.nextInt();
		System.out.print("Ýkinci sayiyi giriniz:");
		sayi2 = scan.nextInt();
		System.out.print("Secenegi giriniz:");
		secenek = scan.nextInt();
		if (secenek >= 0 && secenek <= 3){
			if (secenek == 0 && calisir == true)
				System.out.println("Toplama = " + (sayi1 + sayi2));

			if (secenek == 1 && calisir == true)
				System.out.println("Cýkarma = " + (sayi1 - sayi2));

			if (secenek == 2 && calisir == true)
				System.out.println("Carpma = " + (sayi1 * sayi2));

			if (secenek == 3 && calisir == true)
				System.out.println("Bölme = " + (sayi1 / sayi2));
			
		
		}
		else{
			System.out.println("Boyle bir secenek yok");
			
		}
	}	
}
