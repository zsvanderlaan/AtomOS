﻿/* Copyright (C) Atomix OS Development, Inc - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
* Written by SANDEEP ILIGER <sandeep.iliger@gmail.com>, 07-2014
*/

using System;
using System.Collections.Generic;
using Kernel_alpha.FileSystem.FAT;

namespace Kernel_alpha.FileSystem.FAT
{
    public class RootDirectory
    {
        private List<Lists.Base> Entries;
        private UInt64 DirectorySectory;
        private FatFileSystem FileSystem;

        public RootDirectory(FatFileSystem FS, UInt64 DirSector)
        {
            FileSystem = FS;
            Entries = new List<Lists.Base>();
            DirectorySectory = DirSector;
        }

        public void AddEntry(Lists.Base Entry)
        {
            Entries.Add(Entry);
        }

        public List<Lists.Base> GetEntries
        { get { return this.Entries; } }
    }
}
