foreach (string id in sourceIDs.Split(new char[] { ',' },
StringSplitOptions.RemoveEmptyEntries))
 {
 sourceId = Convert.ToInt32(id);
 break;
 }


//-----------------------------------------------------------------

 void SomeFunction()
{
	var sourceId;
	foreach (string id in sourceIDs.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries))
	{
		 sourceId = Convert.ToInt32(id);
		 break;
	}
}