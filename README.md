# Translator
Interpreter for simple own programming language



### An example of syntax
```
program test
begin
float a=0
int b =0
int c=0
read(a,b,c)
do while(a<c)
	write(a)
	if(a>b)then
		float temp =a+1
		do while(a<=temp)
			a=a+0.1
			write(a)
		enddo
	fi
	a=a+1
enddo
c = (c==a)?333:-999
write(c)
end
```