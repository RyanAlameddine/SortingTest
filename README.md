# SortingTest
   <body class="c17">
      <p class="c2"><span class="c1">Ryan Alameddine, Nolan Costin, Andrew Zerby</span></p>
      <p class="c2"><span>Selected Bio project:</span></p>
      <p class="c2 c3"><span class="c12"></span></p>
      <p class="c2"><span class="c13">Question:</span><span>&nbsp;</span><span>What is the most efficient (in terms of speed) sorting algorithm?</span></p>
      <p class="c2 c3"><span class="c12"></span></p>
      <p class="c2"><span class="c13">Background:</span><span class="c1">&nbsp;When creating a computer program, you often need to sort a large list of items into a specific order. However, in some applications, such as games or network protocols, memory efficiency and speed is vital to the success of the application. Because of this, various computer scientists and mathematicians have developed a variety of algorithms for sorting sets of data. However, it can be hard to know which ones are actually going to perform better in specific situations, so doing these tests could be very beneficial.</span></p>
      <p class="c2 c3"><span class="c12"></span></p>
      <p class="c2"><span class="c13">Possible Algorithms:</span><span>&nbsp;</span></p>
      <ul class="c6 lst-kix_tfayriz6hkuf-0 start">
         <li class="c2 c9"><span class="c12">Quicksort</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Algorithm Summary:</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-2 start">
         <li class="c2 c8"><span class="c1">Quicksort uses a divide and conquer approach described below:</span></li>
      </ul>
      <ol class="c6 lst-kix_5smgniwwf0yk-0 start" start="1">
         <li class="c2 c8"><span class="c1">Select an element from A[0 : n &ndash; 1] to be the pivot.</span></li>
         <li class="c2 c8"><span class="c1">Rearrange the elements of A to partition A into a left subarray and a right subarray, such that no element in the left subarray are larger than the pivot and no element in the right subarray is smaller than the pivot.</span></li>
         <li class="c2 c8"><span class="c1">Recursively sort the left and the right subarrays.</span></li>
      </ol>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Expected Efficiency:</span></li>
      </ul>
      <a id="t.d9b73cad7819c8a2210dc11a824391a513fda5d3"></a><a id="t.0"></a>
      <table class="c0">
         <tbody>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Worst Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Average Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Best Case</span></p>
               </td>
            </tr>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image1.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image2.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image2.png"></p>
               </td>
            </tr>
         </tbody>
      </table>
      <ul class="c6 lst-kix_tfayriz6hkuf-1">
         <li class="c2 c10"><span>Source: </span><span class="c16"><a class="c15" href="https://www.google.com/url?q=https://web.stanford.edu/class/archive/cs/cs339/cs339.2002/qsort.pdf&amp;sa=D&amp;ust=1542933304349000">https://web.stanford.edu/class/archive/cs/cs339/cs339.2002/qsort.pdf</a></span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-0">
         <li class="c2 c9"><span class="c12">Mergesort</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Algorithm Summary:</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-2 start">
         <li class="c2 c8"><span class="c1">Mergesort uses a divide and conquer approach described below:</span></li>
      </ul>
      <ol class="c6 lst-kix_h3y1padr2nyv-0 start" start="1">
         <li class="c2 c8"><span class="c1">Divide the array repeatedly into two halves </span></li>
         <li class="c2 c8"><span class="c1">Stop dividing when there is single element left. By definition, single elements are already sorted. </span></li>
         <li class="c2 c8"><span class="c1">Continue merging the two already sorted subarrays into sorted subarrays until they are all merged into one sorted array.</span></li>
      </ol>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Expected Efficiency:</span></li>
      </ul>
      <a id="t.bf0894b8db1bb94d1b46ca6c3eab41dcdfa2ef82"></a><a id="t.1"></a>
      <table class="c0">
         <tbody>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Worst Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Average Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Best Case</span></p>
               </td>
            </tr>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image3.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image2.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image2.png"></p>
               </td>
            </tr>
         </tbody>
      </table>
      <ul class="c6 lst-kix_tfayriz6hkuf-1">
         <li class="c2 c10"><span>Source: </span><span class="c16"><a class="c15" href="https://www.google.com/url?q=https://pdfs.semanticscholar.org/6804/987ab63d1879aa55ba68224dced142ce8774.pdf&amp;sa=D&amp;ust=1542933304355000">https://pdfs.semanticscholar.org/6804/987ab63d1879aa55ba68224dced142ce8774.pdf</a></span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-0">
         <li class="c2 c9"><span class="c12">Bubble Sort</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Algorithm Summary:</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-2 start">
         <li class="c2 c8"><span class="c1">This set of instructions repeats until the correct order has been found:</span></li>
      </ul>
      <ol class="c6 lst-kix_b2cumwl3i6c5-0 start" start="1">
         <li class="c2 c8"><span class="c1">Mark the first element in the array. </span></li>
         <li class="c2 c8"><span class="c1">If marked value is higher than the next value, swap them.</span></li>
         <li class="c2 c8"><span class="c1">Move the marker up one.</span></li>
         <li class="c2 c8"><span class="c1">Repeat step two until you hit the end of the array.</span></li>
         <li class="c2 c8"><span class="c1">If the array is not sorted, go back to step two.</span></li>
      </ol>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Expected Efficiency:</span></li>
      </ul>
      <a id="t.4e6b828615d6c17ac9c78a2ae8a53133051b9c9e"></a><a id="t.2"></a>
      <table class="c0">
         <tbody>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Worst Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Average Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Best Case</span></p>
               </td>
            </tr>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image1.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image4.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image5.png"></p>
               </td>
            </tr>
         </tbody>
      </table>
      <ul class="c6 lst-kix_tfayriz6hkuf-1">
         <li class="c2 c10"><span>Source: </span><span class="c16"><a class="c15" href="https://www.google.com/url?q=https://users.cs.duke.edu/~ola/bubble/bubble.pdf&amp;sa=D&amp;ust=1542933304360000">https://users.cs.duke.edu/~ola/bubble/bubble.pdf</a></span><span class="c1">&nbsp;</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-0">
         <li class="c2 c9"><span class="c12">Insertion Sort</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Algorithm Summary:</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-2 start">
         <li class="c2 c8"><span class="c1">This algorithm works by inserting values into their respective spots in a list</span></li>
      </ul>
      <ol class="c6 lst-kix_jdfp8j7576s-0 start" start="1">
         <li class="c2 c8"><span class="c1">Move the first value into a new list.</span></li>
         <li class="c2 c8"><span class="c1">Check the next value, and search through the new list until you find the spot the value should be inserted.</span></li>
         <li class="c2 c8"><span class="c1">Insert the value.</span></li>
         <li class="c2 c8"><span class="c1">Repeat step two until the original is empty.</span></li>
      </ol>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Expected Efficiency:</span></li>
      </ul>
      <a id="t.4e6b828615d6c17ac9c78a2ae8a53133051b9c9e"></a><a id="t.3"></a>
      <table class="c0">
         <tbody>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Worst Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Average Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Best Case</span></p>
               </td>
            </tr>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image1.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image4.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image5.png"></p>
               </td>
            </tr>
         </tbody>
      </table>
      <ul class="c6 lst-kix_tfayriz6hkuf-1">
         <li class="c2 c10"><span>Source: </span><span class="c16"><a class="c15" href="https://www.google.com/url?q=https://www.irjet.net/archives/V3/i12/IRJET-V3I12115.pdf&amp;sa=D&amp;ust=1542933304365000">https://www.irjet.net/archives/V3/i12/IRJET-V3I12115.pdf</a></span><span>&nbsp;</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-0">
         <li class="c2 c9"><span class="c12">Heapsort</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Algorithm Summary:</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-2 start">
         <li class="c2 c8"><span class="c1">This algorithm works by creating a heap tree with the data. It then swaps the top and bottom nodes on the tree until the list is sorted.</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-1">
         <li class="c2 c10"><span class="c1">Expected Efficiency:</span></li>
      </ul>
      <a id="t.bf0894b8db1bb94d1b46ca6c3eab41dcdfa2ef82"></a><a id="t.4"></a>
      <table class="c0">
         <tbody>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Worst Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Average Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Best Case</span></p>
               </td>
            </tr>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image3.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image2.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image2.png"></p>
               </td>
            </tr>
         </tbody>
      </table>
      <ul class="c6 lst-kix_tfayriz6hkuf-1">
         <li class="c2 c10"><span>Source: </span><span class="c16"><a class="c15" href="https://www.google.com/url?q=https://file.scirp.org/pdf/JCC_2017102715100595.pdf&amp;sa=D&amp;ust=1542933304369000">https://file.scirp.org/pdf/JCC_2017102715100595.pdf</a></span><span class="c1">&nbsp;</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-0">
         <li class="c2 c9"><span class="c12">Selection sort</span></li>
      </ul>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Algorithm Summary:</span></li>
      </ul>
      <ol class="c6 lst-kix_cfp4a04kn4ej-0 start" start="1">
         <li class="c2 c8"><span class="c1">Put a &ldquo;sorted&rdquo; marker at the beginning of the array.</span></li>
         <li class="c2 c8"><span class="c1">Find the lowest value in the array, and swap it with the first value after the sorted marker.</span></li>
         <li class="c2 c8"><span class="c1">Move the sorted marker up by one.</span></li>
         <li class="c2 c8"><span class="c1">Repeat step two until the marker reaches the end of the array.</span></li>
      </ol>
      <ul class="c6 lst-kix_tfayriz6hkuf-1 start">
         <li class="c2 c10"><span class="c1">Expected Efficiency:</span></li>
      </ul>
      <a id="t.d1c73cf755b5870e2ed155aa893f5575655446e5"></a><a id="t.5"></a>
      <table class="c0">
         <tbody>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Worst Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Average Case</span></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><span class="c1">Best Case</span></p>
               </td>
            </tr>
            <tr class="c5">
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image1.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image4.png"></p>
               </td>
               <td class="c7" colspan="1" rowspan="1">
                  <p class="c4"><img src="images/image4.png"></p>
               </td>
            </tr>
         </tbody>
      </table>
      <ul class="c6 lst-kix_tfayriz6hkuf-1">
         <li class="c2 c10"><span>Source: </span><span class="c16"><a class="c15" href="https://www.google.com/url?q=https://www.irjet.net/archives/V3/i12/IRJET-V3I12115.pdf&amp;sa=D&amp;ust=1542933304374000">https://www.irjet.net/archives/V3/i12/IRJET-V3I12115.pdf</a></span><span>&nbsp;</span></li>
      </ul>
      <p class="c2 c3"><span class="c12"></span></p>
      <p class="c2"><span class="c13">Materials: </span><span class="c1">Computer</span></p>
      <p class="c2 c3"><span class="c12"></span></p>
      <p class="c2"><span class="c13">Procedure summary:</span><span>&nbsp;Create a C# program in which the computer generates 1000 random numbers between 0 and 1000 </span><span class="c14">inclusive </span><span>(duplicates are not prohibited). Then, </span><span>run multiple the test set </span><span>through multiple sorting algorithms and </span><span>record time elapsed</span><span class="c1">. The program will then repeat this process 1000 times, and record output data in chart.</span></p>
      <p class="c2 c3"><span class="c12"></span></p>
      <p class="c2"><span class="c13">Hypothesis: </span><span>Heapsort and Mergesort </span><span>will tie for the highest speed efficiency, because their best and worst case performance is O(n log n).</span>
      <hr style="page-break-before:always;display:none;">
      </p>
      <p class="c2 c3"><span class="c1"></span></p>
      <p class="c2 c3"><span class="c1"></span></p>
      <p class="c2"><span>BIO</span><span>&nbsp;INDEPENDENT PROJECT</span><span class="c1">&nbsp;</span></p>

   </body>
