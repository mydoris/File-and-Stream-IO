File and Stream I/O
==============
The System.IO namespace contains types that allow synchronous and asynchronous reading and writing on data streams and files.

The following distinctions help clarify the differences between a file and a stream. A file is an ordered and named collection of a particular sequence of bytes having persistent storage. Therefore, with files, one thinks in terms of directory paths, disk storage, and file and directory names. In contrast, streams provide a way to write and read bytes to and from a backing store that can be one of several storage mediums. Just as there are several backing stores other than disks, there are several kinds of streams other than file streams. For example, there are network, memory, and tape streams.

