﻿/* Copyright (C) Atomix OS Development, Inc - All Rights Reserved
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
* Written by SANDEEP ILIGER <sandeep.iliger@gmail.com>, 07-2014
*/

using System;

namespace Kernel_alpha.FileSystem.FAT.Lists
{
    public class Directory : Base
    {
        public Directory(string aName, Details aDetail)
            : base(aName, aDetail)
        {
        }
    }
}
