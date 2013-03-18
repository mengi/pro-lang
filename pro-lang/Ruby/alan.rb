#!/usr/bin/ruby
# encoding: utf-8

class Point
	
	attr_reader :x, :y   
	@@say = 0
	
	def initialize(x, y)
		@x, @y = x, y
		@@say += 1
	end
		
	def sag(other)
		@x > other.x
	end
	
	def sol(other)
		@x < other.x
	end
	
	def sag(other)
		@y > other.y
	end
	
	def sol(other)
		@y < other.y
	end		
	
	def esit(other)
		@x == other.x and @y == other.y
	end
	
	def to_s
		"(#@x, #@y)"
	end
	
	class << self
		def say
			puts "girilen nokta sayis = #@@say"
		end
		
		
	end		
	
	def ekle(x, y)
		@x += x
		@y += y
		self 
	end
	
	def topla(other)
		self.class.new @x + other.x, @y + other.y
	end
	
end

class Daire < Point
	attr_reader :r
	
	def initialize(*coods, r)
		super *coods
		@r = r
	end
	
	def cevre
		2 * Math::PI * @r
	end
	
	def alan
		Math::PI * (@r ** 2)
	end	  

end




def main
		
  c = Daire.new 10, 10, 10
  p,q,r = Point.new(0,1), Point.new(2,5), Point.new(6,7)
  Point.say
  puts "#{p.topla(q)}"
  puts "#{c} çemberinin alanı: #{c.alan}"
  puts "#{c} cemberinin cevresi: #{c.cevre}"
  puts "#{p} noktası #{q} noktasının " + (p.sol(q) ? "solunda" : "sağında")
  
end

if __FILE__ == $0
    main
end
