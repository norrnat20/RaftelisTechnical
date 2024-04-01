# makefile
# Created: 3/30/2024 - Natalie Norris
# Modified: 3/31/2024 - Natalie Norris
# 
run: run.exe
		mono run.exe

run.exe: Mainy.cs ParcelParser.cs ParcelSorter.cs ParcelPrinter.cs
		mcs -out:run.exe Mainy.cs ParcelParser.cs ParcelSorter.cs ParcelPrinter.cs


# clean
clean: 
	rm *.exe