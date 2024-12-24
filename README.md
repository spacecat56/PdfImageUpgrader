# PdfImageUpgrader Readme

## Motivation
Many authors who prepare material for print-on-demand services ("POD") use Microsoft Word (R) (Word") instead of more expensive / less familiar desktop publishing applications. In any case the expected output from the author takes the form of a pdf file. Word can export to, or save as, pdf files with various options; or it can be used to print" to a pdf using an installed virtual device such as the one Microsoft provides with recent versions of Windows.

If the work includes images or other graphics the resolution of each image, as embedded in the pdf file, is an important factor in the visual quality of the ultimate printed book.  Typically these are expected to be between 300 and 600ppi (pixels per inch).

The instructions for how to get Word to (1) preserve the full quality of images that are inserted into a document and (2) emit high quality images into a pdf, are endlessly repeated all over the web. In the current version of Word that is available by subscription to Microsoft 356, the former works, but the latter **does not**. It can readily be seen by expanding the docx file (it is a stylized zip file) that the images are unchanged if the correct options are set. But on "export" Word has been observed to downsample all images to 200ppi, **regardless of settings**; this may have been different in earlier versions of Word and this downsampling is not really "documented behavior", but the current help AI will "helpfully" note that Word "may" do downsample to 200dpi.  Sigh. Using the aforementioned printer driver will often result in somewhat higher resolution images in the pdf file, but its behavior seems hard to predict and it was not observed to emit 600ppi images without downsampling. 

## Use case
The PdfImageUpgrader application was developed to address this problem, and no other.  The use case for PdfImageUpgrader is as follows:
1. Finish (to whatever extent suits your author/publish process) the Word docx with the graphics etc., exactly as it should appear, e.g., if printed to paper from Word it looks as intended
2. Export or "print" the whole thing to pdf, as if you will be submitting the file to your POD service; usually this requires all fonts to be embedded, which can be accomplished using the PDF/A option in export, or using the print driver.
3. Use PdfImageUpgrader to create a version of that pdf "upgraded" with your full-resolution images.

In brief, to enable step (3), PdfImageUpgrader is used to 
- extract copies of the original images from the docx (Word) file (if you set the options correctly in Word File/Options/Advanced, these copies retain your full ppi)
- extract copies the images from the pdf (typically, downsampled) 
- walk through the list of full-res images and match each of them up with the corresponding image from the pdf
- review proposed replacements, and optionally reject them case-by-case
- overwrite the lower-res image streams in the pdf with the full-res images and save the results to a new, upgraded pdf file.

The matchup process is not 100% foolproof, but the problem is very greatly simplified by the intended use case and by some simple observations of the internal behavior of the applications.  Word internally stores inserted images in a "Media" "folder" inside the docx, and renames them sequentially in the order of appearance. There may be a few other "images" in the pdf, but the ones we are concerned with appear in the same order and each is a somewhat degraded copy of one of the originals.  So, they can be lined up by just waslking the lists of images in the order of appearance, and checking each for a match using an image comparison "error metric". The "Fuzz" metric has been found in testing to work extremely well **when used within the intended workflow**, clearly because the downsampled image in the pdf actually is a "fuzzed" version of the original image.  

If you feed PdfImageUpgrader a docx that does not actually match the pdf, results are not well-defined. It may find matching images; it may find images that are "close" but require manual confirmation.  If you try really hard you can make a mess. Too bad. Do NOT complain about this.  That is entirely **your problem** because PdfImageUpgrader lets you see each pair of images and only makes the changes that you accept.  

## Further thoughts

There are several things that remain very fussy.  Rounding of the image size by Word is one of these.  To avoid these problems, you should first be sure to create each image such that its scale as you intend it to appear in your Word document will be exactly 100%, and set the image scale in Word to 100% and also (these can be tweaked separately!) verify that it has the exact correct dimensions in inches. You should make sure that your image files' internal properties are set to the ppi that you intend, not the 96 or 110 that many image editors will default to. And, you **must** make sure that the number of pixels in each dimension of each image divides exactly by its ppi, at the second decimal place or above (fewer).  Examples: at 600ppi, 3600 pixels is ok (6.0"), 3900 pixels is ok (6.5") but 3700 pixels is **not ok** (6.1666...") because Word will round off the size of the rectangle for the image and some undesirable things are very likely to happen: the image will be resampled for printing, degrading the print quality; if the box size rounds down on a 600ppi image the resulting density (ppi) will be too high for the POD printer's specs; if the box size rounds up on a 300ppi image the resulting density may be low enough to trigger a warning or error at the POD printer...

PdfImageUpgrader **does not** make any changes to the layout of the page in the pdf, it **only** rewrites each matched image stream with the full res image data drawn out of the original Word docx file.  If you allowed any issues with size and rounding in your document, the issue may be better, or worse, or the same after you apply PdfImageUpgrader.

## Development environment

PdfImageUpgrader was developed in Visual Studio 2022 Community Edition, using .net 8, c# 9, Winforms, and the iText and Magick libraries. Interested persons should be able to build the application easily in Visual Studio by downloading the project and opening the solution file. 

The current "free" version of iText is used, and it is GPL, so, PdfImageUpgrader is made available here also under the GPL.

## Install

Prospective users who do not wish to build the program can download the "release", which is just a zip file of a locally published "click once" application.  Unzip the file and run the setup program to install PdfImageUpgrader.

Github is very funny about this, practically hiding the download... click the "tag" under "Releases" near the top right of this page.

## License Summary

This program is free software.
It is licensed under the GNU AGPL version 3 or later.
That means you are free to use this program for any purpose;
free to study and modify this program to suit your needs;
and free to share this program or your modifications with anyone.
If you share this program or your modifications or use it as a web service you must grant the recipients the same freedoms.
To be more specific: you must share the source code under the same license.
For details see https://www.gnu.org/licenses/agpl-3.0.html

## NO WARRANTY
PdfImageUpgrader has proven useful to its author, and is offered here for free in the hope that others may find it useful. 
Users should exercise all necessary care to esure that they do not overwrite or delete any original files,.
As the license says, there is **no warranty** of any kind.


## Trademarks acknowledged

Microsoft, Microsoft 365, Microsoft Word, and Windows are trademarks and/or registered trademarks of Microsoft Corporation. No endorsement or other relationship, aside from that of an individual licensed user, should be inferred from mention of these marks or products.

