import javax.swing.*;
// import java.text.NumberFormat;
public class DaireAlanCevre {
	public double DaireAlan(double yari_cap){
		double Alan = Math.PI * (Math.pow(yari_cap, 2));
		return Alan;
	}
	public double DaireCevre(double yari_cap){
		double Cevre = 2 * Math.PI * yari_cap ;
		return Cevre;
	}
	public static void main(String[] args) {
		DaireAlanCevre nesne = new DaireAlanCevre();
		String cap = JOptionPane.showInputDialog("double yari cap gir");
		if((Double.parseDouble(cap) / 2) <= 0){
			System.out.println("Düzgün gir");
		}else{
			System.out.println("alan :"+ nesne.DaireAlan(Double.parseDouble(cap) / 2));
			System.out.println("cevre :"+ nesne.DaireCevre(Double.parseDouble(cap) / 2));
		}
		System.exit(0);
	}
	

}
