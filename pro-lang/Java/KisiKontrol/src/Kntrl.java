import javax.swing.*;

import java.text.NumberFormat;

public class Kntrl {
	

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		String kisi_sayisi, aranan;
		kisi_sayisi = JOptionPane.showInputDialog("kisi sayini giriniz:");
		// System.out.println("kisi sayisi :"+kisi_sayisi);
		String ad_tut[] = new String[Integer.parseInt(kisi_sayisi)];
		
		for(int i = 0; i < Integer.parseInt(kisi_sayisi); i++){
			ad_tut[i] = JOptionPane.showInputDialog(null, "Lütfen kullanici adinizi giriniz:");
		}
		
		int index = -1;
		aranan = JOptionPane.showInputDialog("Aradiginiz kullanici adini giriniz:");
		
		for(int k = 0; k < ad_tut.length; k++){
			if(aranan.equals(ad_tut[k]) == true){
				index = k;
				JOptionPane.showMessageDialog(null, index +"numarali indexe sahib kullanici...");
				break;
		}
		if(index == -1){
			JOptionPane.showMessageDialog(null, "Aradıgınız kullanici adi bulunmamaktadir.");
		}
	}
		System.exit(0);
}

}
