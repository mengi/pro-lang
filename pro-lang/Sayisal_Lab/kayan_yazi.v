module dogan2(CLOCK_50,KEY,HEX0,HEX1,HEX2,HEX3,HEX4,HEX5,HEX6,HEX7);	
input [3:0]KEY; 	input CLOCK_50;
	
reg [26:0] Q; 	
reg [26:0] A = 27'd49999999
wire esit ; 
reg [23:0]yak = 27'd7;
parameter n = 27; 
output [0:6] HEX0,HEX1,HEX2,HEX3,HEX4,HEX5,HEX6,HEX7; // Cikis portlarimiz (Cikislarimiz)
			
	always @(posedge CLOCK_50)begin 

		if (Q == A)begin 
			Q <= 27'd0; // Esit oldugunda sifirla
		end
		else begin // Degilse
			Q <= Q + 1'd1; 
		end
	end
	always @(KEY[0] or KEY[1])begin
		if(KEY[0])begin 
			A = A - 27'd5000000; 
		end
		else if (KEY[1]) begin 
			A = A + 27'd5000000; 
		end	
	end
	
	assign esit = (A==Q); 			
			
	always @(posedge esit) begin 
		 yak = {yak[20:0],yak[23:21]}; 
	end
			
	bcd7seg digit6 (yak[2:0], HEX7);
	bcd7seg digit5 (yak[5:3], HEX6);
	bcd7seg digit4 (yak[8:6], HEX5);
	bcd7seg digit3 (yak[11:9], HEX4);
	bcd7seg digit2 (yak[14:12], HEX3);
	bcd7seg digit1 (yak[17:15], HEX2);
	bcd7seg digit0 (yak[20:18], HEX1);
	bcd7seg digit7 (yak[23:21], HEX0);

endmodule


module bcd7seg (bcd, display);
			 input [2:0] bcd;
			 output reg [0:6] display;
	       always @ (bcd)
			 case (bcd)
			 
			 
			 3'b111: display = 50'b0000000;
			 
			default: display = 50'b1111111;
	endcase
endmodule
		
