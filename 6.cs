foreach (DirectoryInfo dir in dirs.GetDirectories())
{
 //create folder{16}
 stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
 stream.Read(new byte[1],0, 1);
stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(
SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length), 0, 4);
 stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') +
 dir.Name.Replace('\\', '/')),0,
 Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') +
 dir.Name.Replace('\\', '/')).Length);
 //send folder name
 stream.Read(new byte[1], 0, 1);//Ok
}

//-----------------------------------------------------------

void SomeFunction()
{
	foreach (DirectoryInfo dir in dirs.GetDirectories())
	{
		 //create folder{16}
		 stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
		 stream.Read(new byte[1],0, 1);
		 stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(Replace2().Length), 0, 4);
		 stream.Write(Encoding.UTF8.GetBytes(Replace2(),0,Encoding.UTF8.GetBytes(SReplace2().Length);
		 //send folder name
		 stream.Read(new byte[1], 0, 1);//Ok
	}
}
string Replace2()
{
    return SubFolder.Replace('\\', '/') +dir.Name.Replace('\\', '/'));
}