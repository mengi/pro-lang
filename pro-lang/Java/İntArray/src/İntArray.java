import java.util.ArrayList;
import java.lang.System;

public class İntArray {
	ArrayList<Integer> liste = new ArrayList<Integer>();
	public void add(int rakam){
		liste.add(rakam);
	}
	public void listeGoster(){
		System.out.println("Girilen Sayilarin Listesi\n-------------------------");
		for (int i = 0; i < liste.size(); i++) 
			System.out.println(liste.get(i));
		this.reverse();
		this.SiralaBuyuk();
		this.SiralaKucuk();
		System.out.println("\nEn buyuk => " + this.Max());
		System.out.println("En Kuyuk => " + this.Min());
	} 
	private int Max(){
		int max = 0;
		for (int i = 0; i < liste.size(); i++) {
			if (max <= liste.get(i)){
				max = liste.get(i);
			}	
		}
		return max;
	}
	private int Min(){
		int min = liste.get(0);
		for (int i = 0; i < liste.size(); i++) {
			if (min >= liste.get(i)){
				min = liste.get(i);
			}
		}
		return min;
	}
	private void reverse(){
		int boyut = liste.size() - 1;
		System.out.println("\nGirilen Sayilarin Reverse Etme \n------------------------------");
		for ( ; 0 <= boyut; boyut--) 
			System.out.println(liste.get(boyut));
		}
	private void SiralaKucuk(){
		int tmp;
		int toplam = 0;
		int [] sayilar = new int[liste.size()];
		for (int i = 0; i < sayilar.length; i++) {
			sayilar[i] = liste.get(i);
			toplam += sayilar[i];
		}
		System.out.println("\n****************");
		System.out.println("\n Liste Toplam = "+ toplam);
		System.out.println("\n Liste Ortalama = "+ toplam / liste.size());
		for (int i = 0; i < sayilar.length; i++) {
			for (int j = 0; j < sayilar.length; j++) {
				if (sayilar[i] < sayilar[j]) {
					tmp = sayilar[i];
					sayilar[i] = sayilar[j];
					sayilar[j] = tmp;
				}
			}
		}
		System.out.println("\nKucukten Buyuge \n****************");
		for (int i = 0; i < sayilar.length; i++) {
			System.out.println(sayilar[i]);
		}
	}
	private void SiralaBuyuk(){
		int tmp;
		int [] sayilar = new int[liste.size()];
		for (int i = 0; i < sayilar.length; i++) {
			sayilar[i] = liste.get(i);
		}
		
		for (int i = 0; i < sayilar.length; i++) {
			for (int j = 0; j < sayilar.length; j++) {
				if (sayilar[i] > sayilar[j]) {
					tmp = sayilar[i];
					sayilar[i] = sayilar[j];
					sayilar[j] = tmp;
				}
			}
		}
		System.out.println("\nBuyuten Kucuge \n***************");
		for (int i = 0; i < sayilar.length; i++) {
			System.out.println(sayilar[i]);
		}
	}
	public void Sil(int index){
		System.out.println("\n Silinen Elemandan Sonra \n-------------------------");
		if (index >= liste.size()) {
			int a = index % liste.size();
			liste.remove(a);
		}else {
			liste.remove(index);
		}
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		İntArray nesne = new İntArray();
		nesne.add(10);
		nesne.add(29);
		nesne.add(12);
		nesne.add(35);
		nesne.add(-2);
		nesne.listeGoster();
		nesne.Sil(5);
		nesne.listeGoster();
	}

}

