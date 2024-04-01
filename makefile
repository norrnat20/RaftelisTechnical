# makefile
# Created: 3/30/2024 - Natalie Norris
# Modified: 3/31/2024 - Natalie Norris
# 
SOURCES=Main.cs ParcelParser.cs ParcelSorter.cs ParcelPrinter.cs Parcel.cs

run: run.exe
		mono run.exe

run.exe: $(SOURCES)
		mcs -out:run.exe $(SOURCES)


# clean
clean: 
	rm *.exe