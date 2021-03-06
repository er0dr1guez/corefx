// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Collections.Tests
{
    public class SortedList_CapacityTests
    {
        [Fact]
        public void TestGetCapacityBasic()
        {
            String strValue = String.Empty;

            SortedList list;
            Int32 iCurrentDefaultCapacity;
            Int32 capacity;

            iCurrentDefaultCapacity = 0;
            list = new SortedList();
            Assert.Equal(list.Capacity, iCurrentDefaultCapacity);

            list.Capacity = 3;
            Assert.Equal(3, list.Capacity);

            capacity = 0;
            list = new SortedList(capacity);
            Assert.Equal(list.Capacity, capacity);

            capacity = 5000;
            list = new SortedList(capacity);
            Assert.Equal(list.Capacity, capacity);
        }
    }
}

