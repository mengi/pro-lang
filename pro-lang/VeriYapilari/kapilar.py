#!/usr/bin/python
#-*-coding :utf-8 -*-
#####################################KAPILARR##########################################
#####################################LOGICGATE#########################################
class LogicGate:
	def __init__(self, n):
		self.label = n
		self.output = None
	
	def getlabel(self):
		return self.label
		
	def getOutput(self):
		self.output = self.performGatelogic()
		return self.output

######################################BINARYGATE#######################################

class BinaryGate(LogicGate):
	def __init__(self, n):
		LogicGate.__init__(self, n)
		
		self.pinA = None
		self.pinB = None
	
	def getpinA(self):
		return input("Enter pinA input for gate" + self.getlabel() + "-->")
		
	def getpinB(self):
		return input("Enter pinB input for gate" + self.getlabel() + "-->")
		
		#################DENEMELER########################

#~ g1 = LogicGate("G1")
#~ print  g1.getlabel()
#~ LogicGate.__init__(g1, "G1")


#~ g1 = BinaryGate("G1")
#~ LogicGate.__init__(g1, "G1")
#~ print g1.label
#~ print g1.output
		
##################################UNARYGATE#######################################
class UnaryGate(LogicGate):
	def __init__(self, n):
		LogicGate.__init__(self, n)
		
		self.pin = None
		
	def getpin(self):
		return input("Enter pin input for gate" + self.getlabel() + "-->")
		
##################################ANDGATE###########################################
class AndGate(BinaryGate):
	def __init__(self, n):
		BinaryGate.__init__(self, n)
		
	def performGatelogic(self):
		a = self.getpinA()
		b = self.getpinB()
		if a == 1 and b == 1:
			return 1
		else:
			return 0

g2 = AndGate("G")
print g2.getlabel()
print g2.getOutput()
g2.Output = g2.performGatelogic()
g2.getpinA()

#################################ORGATE###############################################
class OrGate(BinaryGate):
	def __init__(self, n):
		BinaryGate.__init__(self, n)
		
	def performGatelogic(self):
		a = self.getpinA()
		b = self.getpinB()
		if a == 0 and b == 0:
			return 0
		else:
			return 1
			
###############################NOTGATE##################################################
class NotGate(UnaryGate):
	def __init__(self,n):
		UnaryGate.__init__(self,n)
	def performGateLogic(self):
		a = self.getPin()
		if a==0:
			return 1
		else:
			return 0			

###############################CONNECTOR(BAGLAYICI)##################################
class Connector:
	def __init__(self, fgate, tgate):
		self.fromgate = fgate
		self.togate = tgate
		
		tgate.setNextpin(self)
	
	def getFrom(self):
		return self.fromgate
	
	def getTo(self):
		return self.togate
		
##############################SETNEXTPIN YONETIMI#####################################
def setNextpin(self, source):
	if self.pinA == None:
		self.pinA = source
	else:
		if self.pinB == None:
			self.pinB = source
		else:
			print "Cannot Connect: No Empty Preus"
			
def getPinA(self):
	if self.pinA == None:
		return input("Enter Pin A input for gate" + self.getName() + "-->")
	else:
		return self.pinA.getFrom().getOutput()

#~ g1 = AndGate("G1")
#~ g2 = AndGate("G2")
#~ g3 = OrGate("G3")
#~ g4 = UnaryGate("G4")
#~ c1 = Connector(g1, g3)
#~ c2 = Connector(g2, g3)
#~ c3 = Connector(g3, g4)
#~ g4.getOutput()
