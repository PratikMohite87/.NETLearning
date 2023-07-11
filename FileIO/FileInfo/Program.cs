// The FileInfo class is used to deal with file and its operations in C#.
// It provides properties and methods that are used to create, delete and read file.
// It uses StreamWriter class to write data to the file.

using static System.Net.Mime.MediaTypeNames;
using System.IO;

FileInfo fi = new FileInfo("G:\\.NET Learnings\\FileIO\\TextFile.txt");

#region FileInfo Properties
/*

Attributes      :	It is used to get or set the attributes for the current file or directory.
CreationTime    :	It is used to get or set the creation time of the current file or directory.
Directory       :	It is used to get an instance of the parent directory.
DirectoryName   :	It is used to get a string representing the directory's full path.
Exists          :	It is used to get a value indicating whether a file exists.
FullName        :	It is used to get the full path of the directory or file.
IsReadOnly      :	It is used to get or set a value that determines if the current file is read only.
LastAccessTime  :	It is used to get or set the time from current file or directory was last accessed.
Length          :	It is used to get the size in bytes of the current file.
Name            :	It is used to get the name of the file.

*/
#endregion

#region FileInfo Methods
/*

AppendText()        It is used to create a StreamWriter that appends text to the file represented by this instance of the FileInfo.
CopyTo(String)	    It is used to copy an existing file to a new file.
Create()            It is used to create a file.
CreateText()	    It is used to create a StreamWriter that writes a new text file.
Decrypt()           It is used to decrypt a file that was encrypted by the current account using the Encrypt method.
Delete()            It is used to permanently delete a file.
Encrypt()	        It is used to encrypt a file so that only the account used to encrypt the file can decrypt it.
GetAccessControl()	It is used to get a FileSecurity object that encapsulates the access control list (ACL) entries.
MoveTo(String)      It is used to move a specified file to a new specified location.
Open(FileMode)      It is used to open a file in the specified mode.
OpenRead()	        It is used to create a read-only FileStream.
OpenText()	        It is used to create a StreamReader with UTF8 encoding that reads from an existing text file.
OpenWrite()	        It is used to create a write-only FileStream.
Refresh()	        It is used to refresh the state of the object.
Replace(String, String)	It is used to replace the contents of a specified file with the file described by the current FileInfo object.
ToString()	        It is used to return the path as a string.

*/
#endregion