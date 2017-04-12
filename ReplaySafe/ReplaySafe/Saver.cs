using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaySafe
{
    class Saver
    {
        String BackupPath;
        String SourcePath;

        public Saver(String Sourcepath, String Backuppath)
        {
            BackupPath = Backuppath;
            SourcePath = Sourcepath;

            // Look for unbackuped files, and save them
            // Look in replay folder, since sourcepath is the osu folder
            CopyEverything(SourcePath + @"\Data\r\");
            CopyEverything(SourcePath + @"\Replays\");

            StartListener(SourcePath + @"\Data\r\");
            StartListener(SourcePath + @"\Replays\");
        }

        public void StartListener(String path)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.LastAccess;
            // Only watch text files.
            watcher.Filter = "*";

            // Add create event handlers.
            watcher.Created += new FileSystemEventHandler(OnCreate);

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Started file listener on " + path);
        }

        // Define the event handlers.
        private async void OnCreate(object source, FileSystemEventArgs e)
        {
            String filename = e.FullPath;

            if (IsReplayFile(filename))
            {
                // Backup file when new created
                Console.WriteLine("Found new file " + e.FullPath);

                await Task.Delay(1000);
                BackupFile(e.FullPath);
            }
        }

        private void CopyEverything(String frompath)
        {
            String[] SourceFiles = Directory.GetFiles(frompath);
            String[] BackupFiles = Directory.GetFiles(BackupPath);

            // Looks for every file in dir and copy new ones
            foreach (String file in SourceFiles)
            {
                if (IsReplayFile(file))
                    BackupFile(file);
            }

            // Restore file that have been deleted
            foreach (String file in BackupFiles)
            {
                RestoreFile(file);
            }
        }

        private void BackupFile(String File)
        {
            // Copy a single file to the backup dir
            String filename = getFileName(File);
            String newpath = BackupPath + Path.DirectorySeparatorChar + filename;

            // Check if file already exists
            if (!System.IO.File.Exists(newpath))
            {
                System.IO.File.Copy(File, newpath);
                Console.WriteLine("Backuped file " + filename);
            }
            else
                Console.WriteLine("Skipped backup file " + filename);
        }

        private void RestoreFile(String File)
        {
            // Restore a single file to the osu /r dir
            String filename = getFileName(File);
            String newpath = SourcePath + @"\Data\r" + Path.DirectorySeparatorChar + filename;

            // Check if file already exists
            if (!System.IO.File.Exists(newpath))
            {
                System.IO.File.Copy(File, newpath);
                Console.WriteLine("Restored file " + filename);
            }
            else
                Console.WriteLine("Skipped restore file " + filename);
        }
        private String getFileName(String path)
        {
            // Split file by \ and get last arg (it's the file name)
            String[] a = path.Split(Path.DirectorySeparatorChar);
            String filename = a[a.Length - 1];
            return filename;
        }

        private bool IsReplayFile(String file)
        {
            return (file.EndsWith(".osr") || file.EndsWith(".osg"));
        }
    }
}
