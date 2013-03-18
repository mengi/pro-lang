#!/usr/bin/ruby
# encoding: utf-8

class Ucgen
	attr_reader :x, :y, :z
	
	@@say = 0
	
	def initialize(x, y, z)
		@x, @y, @z = x, y, z
		@@say += 1		
	end
	
	def cevre
		"#{@x + @y + @z}"
	end
	
	class << self
		def say 
			puts "ucgen sayisi = #@@say"
		end	
	end	

end

class Kenar < Ucgen
	attr_reader :r
	
	def initialize(*coods, r)
		super *coods
		@r = r
	end
	

	def alan
		"alani = #{((@z + @x + @y) * @r) /2}"
	end
end

		


def main
	c = Ucgen.new(1,2,3)
	a = Kenar.new 2, 3, 5, 5
	Ucgen.say
	puts "cvre = #{c.cevre}"
	puts "#{a.alan}"
end
if __FİLE__ = $0
	main
end	
