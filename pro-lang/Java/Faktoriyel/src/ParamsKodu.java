import java.util.Scanner;


public class ParamsKodu {
	
	public static void main(String [] args){
		System.out.println("Girilen sayilarin toplami = " + topla(25,65,98));
		System.out.println("Girilen sayinin factorial = " + factorial(30));
	}
	public static int topla(int...sayilar){
		int toplam = 0;
		for(int i = 0; i < sayilar.length; i++){
			toplam += sayilar[i]; 
		}
		return toplam;
	}
	public static int factorial(int sayi){
		int topla = 1;
			
		for(int i = 1; i <= sayi; i++)
				
			topla *= i;
			
		return topla;
	}
}
