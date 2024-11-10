{
	"patcher" : 	{
		"fileversion" : 1,
		"appversion" : 		{
			"major" : 8,
			"minor" : 6,
			"revision" : 4,
			"architecture" : "x64",
			"modernui" : 1
		}
,
		"classnamespace" : "box",
		"rect" : [ 357.0, 87.0, 1477.0, 930.0 ],
		"bglocked" : 0,
		"openinpresentation" : 1,
		"default_fontsize" : 12.0,
		"default_fontface" : 0,
		"default_fontname" : "Arial",
		"gridonopen" : 1,
		"gridsize" : [ 15.0, 15.0 ],
		"gridsnaponopen" : 1,
		"objectsnaponopen" : 1,
		"statusbarvisible" : 2,
		"toolbarvisible" : 1,
		"lefttoolbarpinned" : 0,
		"toptoolbarpinned" : 0,
		"righttoolbarpinned" : 0,
		"bottomtoolbarpinned" : 0,
		"toolbars_unpinned_last_save" : 0,
		"tallnewobj" : 0,
		"boxanimatetime" : 200,
		"enablehscroll" : 1,
		"enablevscroll" : 1,
		"devicewidth" : 0.0,
		"description" : "",
		"digest" : "",
		"tags" : "",
		"style" : "",
		"subpatcher_template" : "",
		"assistshowspatchername" : 0,
		"boxes" : [ 			{
				"box" : 				{
					"id" : "obj-101",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 842.0, 64.0, 100.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 842.0, 64.0, 100.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-168",
					"linecount" : 2,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 622.0, 452.0, 279.0, 48.0 ],
					"presentation" : 1,
					"presentation_linecount" : 3,
					"presentation_rect" : [ 541.0, 55.0, 175.0, 69.0 ],
					"text" : "NOTE: for Windows networks set net ork path as a drive letter"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-151",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 416.283944010734558, 447.5, 165.432111978530884, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 169.0, 249.0, 147.619066536426544, 27.0 ],
					"text" : "<--- loop"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-149",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 373.0, 447.5, 24.0, 24.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 133.0, 251.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-100",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 373.0, 479.0, 54.0, 23.0 ],
					"text" : "loop $1"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-129",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 943.0, 1358.0, 137.0, 22.0 ],
					"text" : "scale 0. 127. 600. 1000."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-27",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 688.0, 1157.0, 45.0, 22.0 ],
					"text" : "cverb~"
				}

			}
, 			{
				"box" : 				{
					"format" : 6,
					"id" : "obj-76",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 661.0, 1118.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-78",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 635.0, 1157.0, 45.0, 22.0 ],
					"text" : "cverb~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-179",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1366.0, 1355.0, 137.0, 22.0 ],
					"text" : "scale 0. 127. 400. 1000."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-173",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1024.0, 1157.0, 45.0, 22.0 ],
					"text" : "cverb~"
				}

			}
, 			{
				"box" : 				{
					"format" : 6,
					"id" : "obj-170",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1005.0, 1124.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-171",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 971.0, 1157.0, 45.0, 22.0 ],
					"text" : "cverb~"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-167",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1137.0, 1478.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 516.0, 714.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 4, 1, 0, 0, 10065.0966796875, 0.969589531421661, 0.887726187705994, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-166",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1134.0, 1358.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 516.0, 631.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 5, 1, 0, 0, 815.748046875, 0.281721293926239, 0.450460433959961, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-165",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1134.0, 1251.0, 220.68963623046875, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 518.0, 553.0, 220.68963623046875, 76.595744132995605 ],
					"setfilter" : [ 0, 2, 1, 0, 0, 723.58740234375, 1.607781291007996, 0.711641728878021, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-161",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1038.0, 850.0, 29.5, 22.0 ],
					"text" : "*~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-162",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1011.0, 850.0, 29.5, 22.0 ],
					"text" : "*~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-147",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1052.0, 1444.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-148",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1052.0, 1215.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-150",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1137.0, 1444.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-152",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1134.0, 1215.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-154",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1055.0, 1328.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-155",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1134.0, 1328.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-156",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 971.0, 1065.0, 182.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 518.0, 462.0, 175.0, 27.0 ],
					"text" : "wet nasa"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-157",
					"maxclass" : "newobj",
					"numinlets" : 8,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 971.0, 937.0, 114.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 517.0, 435.0, 176.5, 22.0 ],
					"text" : "nn~ nasa.ts decode"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-158",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 971.0, 976.0, 81.0, 22.0 ],
					"text" : "loadmess -28"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-160",
					"lastchannelcount" : 0,
					"maxclass" : "live.gain~",
					"numinlets" : 2,
					"numoutlets" : 5,
					"orientation" : 1,
					"outlettype" : [ "signal", "signal", "", "float", "list" ],
					"parameter_enable" : 1,
					"patching_rect" : [ 971.0, 1015.0, 182.0, 39.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 518.0, 491.0, 175.0, 39.0 ],
					"saved_attribute_attributes" : 					{
						"valueof" : 						{
							"parameter_initial" : [ -70 ],
							"parameter_initial_enable" : 1,
							"parameter_longname" : "live.gain~[6]",
							"parameter_mmax" : 6.0,
							"parameter_mmin" : -70.0,
							"parameter_modmode" : 0,
							"parameter_shortname" : "live.gain~",
							"parameter_type" : 0,
							"parameter_unitstyle" : 4
						}

					}
,
					"showname" : 0,
					"varname" : "live.gain~[6]"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-131",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 257.0, 1444.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-135",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 257.0, 1215.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-136",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 340.0, 1474.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 25.0, 714.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 1, 1, 0, 0, 9380.998046875, 1.167838335037231, 1.792443752288818, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-137",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 340.0, 1444.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-138",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 337.0, 1247.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 25.0, 553.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 2, 1, 0, 0, 104.812934875488281, 0.993350684642792, 1.581310033798218, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-139",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 337.0, 1215.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-140",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 337.0, 1358.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 25.0, 631.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 7, 1, 0, 0, 291.201934814453125, 0.513728499412537, 2.406617879867554, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-145",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 258.0, 1328.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-146",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 337.0, 1328.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-122",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 629.0, 1444.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-117",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 629.0, 1215.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-106",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 712.0, 1474.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 269.0, 714.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 1, 1, 0, 0, 782.67718505859375, 0.699455976486206, 1.596909642219543, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-112",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 712.0, 1444.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-103",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 709.0, 1247.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 269.0, 553.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 0, 1, 0, 0, 238.512130737304688, 0.89518415927887, 0.971765577793121, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-104",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 709.0, 1215.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"id" : "obj-142",
					"maxclass" : "filtergraph~",
					"nfilters" : 1,
					"numinlets" : 8,
					"numoutlets" : 7,
					"outlettype" : [ "list", "float", "float", "float", "float", "list", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 709.0, 1358.0, 223.881125569343567, 76.595744132995605 ],
					"presentation" : 1,
					"presentation_rect" : [ 269.0, 631.0, 223.881125569343567, 76.595744132995605 ],
					"setfilter" : [ 0, 5, 1, 0, 0, 600.2994384765625, 0.367138713598251, 0.860924184322357, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-134",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 631.0, 1328.0, 71.5, 22.0 ],
					"text" : "biquad~"
				}

			}
, 			{
				"box" : 				{
					"attr" : "edit_mode",
					"id" : "obj-144",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 709.0, 1328.0, 220.68963623046875, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-97",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 445.0, 334.0, 107.560679486819708, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 169.0, 146.571447610855103, 175.0, 27.0 ],
					"text" : "set directory"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-96",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 337.0, 1812.0, 168.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 177.0, 1048.0, 175.0, 27.0 ],
					"text" : "post-master limiter"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-90",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 219.0, 1594.0, 210.638296365737915, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 167.0, 925.0, 232.0, 27.0 ],
					"text" : "/Mute (0 muted, 1 sound)"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-80",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 632.0, 1069.0, 182.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 297.0, 462.0, 175.0, 27.0 ],
					"text" : "wet isis"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-30",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 135.0, 1109.0, 87.0, 22.0 ],
					"text" : "loadmess 600."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-13",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 50.0, 1633.0, 74.0, 22.0 ],
					"text" : "loadmess -8"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-25",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 175.0, 1777.0, 74.0, 22.0 ],
					"text" : "loadmess -5"
				}

			}
, 			{
				"box" : 				{
					"format" : 6,
					"id" : "obj-98",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 69.0, 1144.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-85",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 35.0, 1177.0, 45.0, 22.0 ],
					"text" : "cverb~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-81",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 696.0, 842.0, 29.5, 22.0 ],
					"text" : "*~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-84",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 632.0, 842.0, 29.5, 22.0 ],
					"text" : "*~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-74",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 263.0, 980.0, 81.0, 22.0 ],
					"text" : "loadmess -15"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-75",
					"lastchannelcount" : 0,
					"maxclass" : "live.gain~",
					"numinlets" : 2,
					"numoutlets" : 5,
					"orientation" : 1,
					"outlettype" : [ "signal", "signal", "", "float", "list" ],
					"parameter_enable" : 1,
					"patching_rect" : [ 263.0, 1018.0, 182.0, 39.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 30.0, 491.0, 175.0, 39.0 ],
					"saved_attribute_attributes" : 					{
						"valueof" : 						{
							"parameter_initial" : [ -70 ],
							"parameter_initial_enable" : 1,
							"parameter_longname" : "live.gain~[5]",
							"parameter_mmax" : 6.0,
							"parameter_mmin" : -70.0,
							"parameter_modmode" : 0,
							"parameter_shortname" : "live.gain~",
							"parameter_type" : 0,
							"parameter_unitstyle" : 4
						}

					}
,
					"showname" : 0,
					"varname" : "live.gain~[5]"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-164",
					"maxclass" : "newobj",
					"numinlets" : 8,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 632.0, 940.0, 105.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 297.0, 435.0, 196.0, 22.0 ],
					"text" : "nn~ isis.ts decode"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-159",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 35.0, 1109.0, 91.0, 22.0 ],
					"text" : "lores~ 1100 0.8"
				}

			}
, 			{
				"box" : 				{
					"attr" : "threshold",
					"id" : "obj-143",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 175.0, 1812.0, 150.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 177.0, 1087.0, 150.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 12.0,
					"id" : "obj-141",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "signal", "signal" ],
					"patching_rect" : [ 175.0, 1857.0, 100.0, 22.0 ],
					"text" : "limi~ 2"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-133",
					"linecount" : 2,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 232.0, 1703.0, 98.462086847850287, 48.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 30.0, 964.0, 175.0, 27.0 ],
					"text" : "master gain"
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.850980392156863, 0.427450980392157, 0.427450980392157, 1.0 ],
					"format" : 6,
					"id" : "obj-132",
					"maxclass" : "flonum",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 44.0, 1598.0, 50.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 111.0, 926.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-130",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 107.0, 1598.0, 105.0, 22.0 ],
					"text" : "scale 0. 1. -70. -8."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-128",
					"maxclass" : "newobj",
					"numinlets" : 0,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 107.0, 1566.0, 50.0, 22.0 ],
					"text" : "r --mute"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-127",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 85.0, 251.0, 53.0, 22.0 ],
					"text" : "s --mute"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-126",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"patching_rect" : [ 90.0, 221.0, 69.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 30.0, 926.0, 77.0, 22.0 ],
					"text" : "route /Mute"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-125",
					"lastchannelcount" : 0,
					"maxclass" : "live.gain~",
					"numinlets" : 2,
					"numoutlets" : 5,
					"orientation" : 1,
					"outlettype" : [ "signal", "signal", "", "float", "list" ],
					"parameter_enable" : 1,
					"patching_rect" : [ 41.0, 1708.0, 182.0, 39.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 26.5, 998.0, 182.0, 39.0 ],
					"saved_attribute_attributes" : 					{
						"valueof" : 						{
							"parameter_initial" : [ -70 ],
							"parameter_initial_enable" : 1,
							"parameter_longname" : "live.gain~[4]",
							"parameter_mmax" : 6.0,
							"parameter_mmin" : -70.0,
							"parameter_modmode" : 0,
							"parameter_shortname" : "live.gain~",
							"parameter_type" : 0,
							"parameter_unitstyle" : 4
						}

					}
,
					"showname" : 0,
					"varname" : "live.gain~[4]"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-124",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 689.0, 341.0, 33.0, 22.0 ],
					"text" : ">= 0"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-123",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 735.0, 338.0, 288.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 839.0, 89.0, 326.0, 27.0 ],
					"text" : "<--- use this address for drectory 2"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-121",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "int", "bang" ],
					"patching_rect" : [ 689.0, 267.0, 96.252865612506866, 22.0 ],
					"text" : "t i i b"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-120",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"patching_rect" : [ 689.0, 226.0, 77.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 760.0, 91.0, 77.0, 22.0 ],
					"text" : "route /plays2"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-119",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 523.0, 241.0, 146.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 789.0, 119.0, 184.0, 27.0 ],
					"text" : "change directory"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-118",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 487.0, 244.0, 24.0, 24.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 760.0, 121.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-116",
					"maxclass" : "gswitch2",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 487.0, 285.0, 39.0, 32.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-115",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 622.0, 376.0, 257.0, 23.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 760.0, 154.0, 330.0, 23.0 ],
					"text" : "loadmess prefix /Volumes/Index/directory-2"
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 9.0,
					"id" : "obj-114",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"patching_rect" : [ 1200.0, 233.0, 52.0, 19.0 ],
					"text" : "unpack 1."
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-111",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1285.0, 264.0, 54.0, 23.0 ],
					"text" : "set 100"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-110",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 1103.0, 264.0, 33.0, 22.0 ],
					"text" : "== 1"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-109",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1077.0, 216.0, 68.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 555.0, 867.0, 184.0, 27.0 ],
					"text" : "wander"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-108",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"patching_rect" : [ 1285.0, 335.0, 87.0, 22.0 ],
					"text" : "slide 100. 100."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-107",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 1,
					"outlettype" : [ "float" ],
					"patching_rect" : [ 1157.0, 335.0, 87.0, 22.0 ],
					"text" : "slide 100. 100."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-105",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1157.0, 220.0, 24.0, 24.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 527.0, 869.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-102",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 1285.0, 301.0, 92.0, 23.0 ],
					"text" : "drunk 127. 10."
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-99",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 1157.0, 264.0, 60.0, 23.0 ],
					"text" : "metro 50"
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-18",
					"maxclass" : "newobj",
					"numinlets" : 3,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 1157.0, 301.0, 92.0, 23.0 ],
					"text" : "drunk 127. 10."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-83",
					"maxclass" : "message",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 416.0, 564.0, 29.5, 22.0 ],
					"text" : "0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-79",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 35.0, 980.0, 81.0, 22.0 ],
					"text" : "loadmess -25"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-77",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 632.0, 970.786594390869141, 81.0, 22.0 ],
					"text" : "loadmess -30"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-6",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 263.0, 1069.0, 194.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 30.0, 462.0, 175.0, 27.0 ],
					"text" : "wet magnets"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-3",
					"lastchannelcount" : 0,
					"maxclass" : "live.gain~",
					"numinlets" : 2,
					"numoutlets" : 5,
					"orientation" : 1,
					"outlettype" : [ "signal", "signal", "", "float", "list" ],
					"parameter_enable" : 1,
					"patching_rect" : [ 632.0, 1015.0, 182.0, 39.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 293.0, 491.0, 175.0, 39.0 ],
					"saved_attribute_attributes" : 					{
						"valueof" : 						{
							"parameter_initial" : [ -70 ],
							"parameter_initial_enable" : 1,
							"parameter_longname" : "live.gain~[3]",
							"parameter_mmax" : 6.0,
							"parameter_mmin" : -70.0,
							"parameter_modmode" : 0,
							"parameter_shortname" : "live.gain~",
							"parameter_type" : 0,
							"parameter_unitstyle" : 4
						}

					}
,
					"showname" : 0,
					"varname" : "live.gain~[3]"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-1",
					"lastchannelcount" : 0,
					"maxclass" : "live.gain~",
					"numinlets" : 2,
					"numoutlets" : 5,
					"orientation" : 1,
					"outlettype" : [ "signal", "signal", "", "float", "list" ],
					"parameter_enable" : 1,
					"patching_rect" : [ 35.0, 1018.0, 182.0, 39.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 26.0, 879.0, 182.0, 39.0 ],
					"saved_attribute_attributes" : 					{
						"valueof" : 						{
							"parameter_initial" : [ -70 ],
							"parameter_initial_enable" : 1,
							"parameter_longname" : "live.gain~[2]",
							"parameter_mmax" : 6.0,
							"parameter_mmin" : -70.0,
							"parameter_modmode" : 0,
							"parameter_shortname" : "live.gain~",
							"parameter_type" : 0,
							"parameter_unitstyle" : 4
						}

					}
,
					"showname" : 0,
					"varname" : "live.gain~[2]"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-95",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1493.0, 938.0, 251.0, 20.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 760.0, 569.0, 231.0, 20.0 ],
					"text" : "cmd + click to edit"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-94",
					"linecount" : 3,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1679.0, 814.0, 150.0, 48.0 ],
					"presentation" : 1,
					"presentation_linecount" : 3,
					"presentation_rect" : [ 760.0, 518.0, 179.279279172420502, 48.0 ],
					"text" : "nn~ voice_hifitts_b2048_r48000_z16.ts decode"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-93",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1772.0, 744.0, 72.0, 22.0 ],
					"text" : "prepend set"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-92",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1668.0, 739.0, 72.0, 22.0 ],
					"text" : "prepend set"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-91",
					"linecount" : 3,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1492.0, 814.0, 150.0, 48.0 ],
					"presentation" : 1,
					"presentation_linecount" : 3,
					"presentation_rect" : [ 760.0, 469.0, 179.279279172420502, 48.0 ],
					"text" : "nn~ voice_hifitts_b2048_r48000_z16.ts encode"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-89",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1772.0, 712.0, 91.0, 22.0 ],
					"text" : "append decode"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-88",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1668.0, 712.0, 91.0, 22.0 ],
					"text" : "append encode"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-87",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1668.0, 681.0, 76.0, 22.0 ],
					"text" : "prepend nn~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-86",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "int" ],
					"patching_rect" : [ 1668.0, 653.0, 55.0, 22.0 ],
					"text" : "strippath"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-82",
					"linecount" : 2,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1492.0, 889.0, 251.0, 34.0 ],
					"presentation" : 1,
					"presentation_linecount" : 2,
					"presentation_rect" : [ 760.0, 426.0, 231.0, 34.0 ],
					"text" : "copy model name (without extention) into encoder/decoder"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-70",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1477.0, 551.0, 24.0, 24.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 906.0, 393.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"autopopulate" : 1,
					"id" : "obj-72",
					"items" : [ "additive_1024.ts", ",", "birds_motherbird.ts", ",", "birds_motherbird_b2048_r48000_z16.ts", ",", "birds_pluma_b2048_r48000_z12.ts", ",", "darbouka_onnx.ts", ",", "guitar_iil.ts", ",", "guitar_iil_b2048_r48000_z16.ts", ",", "humpbacks_pondbrain_b2048_r48000_z20.ts", ",", "isis.ts", ",", "magnets_b2048_r48000_z8.ts", ",", "marinemammals_pondbrain_b2048_r48000_z20.ts", ",", "mrp_strengjavera_b2048_r44100_z16.ts", ",", "musicnet.ts", ",", "nasa.ts", ",", "oldsynths.ts", ",", "organ_archive.ts", ",", "organ_archive_b2048_r48000_z16.ts", ",", "organ_bach_b2048_r48000_z16.ts", ",", "percussion.ts", ",", "sax_soprano_franziskaschroeder_b2048_r48000_z20.ts", ",", "sol_full.ts", ",", "sol_ordinario_fast.ts", ",", "vae_cities.ts", ",", "VCTK.ts", ",", "vintage.ts", ",", "voice_hifitts.ts", ",", "voice_hifitts_b2048_r48000_z16.ts", ",", "voice_jvs_b2048_r44100_z16.ts", ",", "voice_vctk_b2048_r44100_z22.ts", ",", "voice_vocalset.ts", ",", "voice_vocalset_b2048_r48000_z16.ts", ",", "water_pondbrain.ts", ",", "water_pondbrain_b2048_r48000_z16.ts", ",", "wheel.ts" ],
					"maxclass" : "umenu",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1477.0, 625.0, 399.0, 22.0 ],
					"prefix" : "~/Documents/Temporal Spaces/pretrained_models/",
					"presentation" : 1,
					"presentation_rect" : [ 760.0, 398.0, 133.333333253860474, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-73",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "int" ],
					"patching_rect" : [ 1477.0, 587.0, 286.0, 23.0 ],
					"text" : "folder \"C:/Users/Max/Documents/RAVE Models\""
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-69",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1484.0, 515.0, 230.0, 20.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 760.0, 370.0, 230.0, 20.0 ],
					"text" : "other models:"
				}

			}
, 			{
				"box" : 				{
					"bubble_outlinecolor" : [ 0.749019607843137, 0.749019607843137, 0.749019607843137, 0.0 ],
					"fontface" : 1,
					"fontsize" : 18.0,
					"id" : "obj-53",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1480.0, 372.0, 181.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 701.0, 375.0, 45.945945918560028, 27.0 ],
					"text" : "nn~",
					"underline" : 1
				}

			}
, 			{
				"box" : 				{
					"bubble_outlinecolor" : [ 0.749019607843137, 0.749019607843137, 0.749019607843137, 0.0 ],
					"fontface" : 1,
					"fontsize" : 18.0,
					"id" : "obj-52",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1480.0, 241.0, 181.0, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 656.0, 8.5, 86.0, 27.0 ],
					"text" : "file input",
					"underline" : 1
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-4",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 121.0, 520.0, 74.0, 22.0 ],
					"text" : "loadmess -3"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-71",
					"linecount" : 2,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 494.0, 95.0, 165.432111978530884, 48.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 265.0, 43.5, 238.0, 27.0 ],
					"text" : "confirm IP!!! (169.254.??.??)"
				}

			}
, 			{
				"box" : 				{
					"bubble" : 1,
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-58",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 32.0, 1373.0, 92.0, 25.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 281.904798030853271, 9.5, 68.0, 25.0 ],
					"text" : "IP"
				}

			}
, 			{
				"box" : 				{
					"bubble" : 1,
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-54",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 28.0, 1340.0, 92.0, 25.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 428.153326451778412, 9.5, 68.0, 25.0 ],
					"text" : "PORT"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-68",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 622.0, 413.0, 165.432111978530884, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 500.952445149421692, 173.33335554599762, 147.619066536426544, 27.0 ],
					"text" : "<--- select file"
				}

			}
, 			{
				"box" : 				{
					"bubble" : 1,
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-67",
					"linecount" : 2,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 20.0, 1291.0, 108.0, 40.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 137.142874717712402, 44.5, 116.0, 25.0 ],
					"text" : "configure OSC"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-66",
					"linecount" : 4,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 440.0, 190.0, 104.24284964799881, 89.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 400.0, 139.0, 293.5, 27.0 ],
					"text" : "<--- REMEMBER TO REFRESH"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-7",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 131.0, 377.0, 33.0, 22.0 ],
					"text" : ">= 0"
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 0.850980392156863, 0.356862745098039, 0.356862745098039, 1.0 ],
					"id" : "obj-8",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 236.0, 267.0, 50.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 437.153326451778412, 176.190498769283295, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-14",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "int", "bang" ],
					"patching_rect" : [ 132.0, 308.0, 96.252865612506866, 22.0 ],
					"text" : "t i i b"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-15",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"patching_rect" : [ 347.0, 283.0, 58.0, 22.0 ],
					"text" : "loadbang"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-43",
					"maxclass" : "button",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 396.5, 191.5, 24.0, 24.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 360.0, 141.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 12.0,
					"id" : "obj-59",
					"lastchannelcount" : 0,
					"maxclass" : "live.gain~",
					"numinlets" : 2,
					"numoutlets" : 5,
					"orientation" : 1,
					"outlettype" : [ "signal", "signal", "", "float", "list" ],
					"parameter_enable" : 1,
					"patching_rect" : [ 209.0, 589.0, 182.0, 39.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 311.0, 182.0, 39.0 ],
					"saved_attribute_attributes" : 					{
						"valueof" : 						{
							"parameter_initial" : [ -70 ],
							"parameter_initial_enable" : 1,
							"parameter_longname" : "live.gain~[1]",
							"parameter_mmax" : 6.0,
							"parameter_mmin" : -70.0,
							"parameter_modmode" : 0,
							"parameter_shortname" : "live.gain~",
							"parameter_type" : 0,
							"parameter_unitstyle" : 4
						}

					}
,
					"showname" : 0,
					"varname" : "live.gain~[1]"
				}

			}
, 			{
				"box" : 				{
					"hiderwff" : 1,
					"id" : "obj-60",
					"maxclass" : "playbar",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "int" ],
					"patching_rect" : [ 302.0, 523.0, 196.0, 19.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 286.0, 196.0, 19.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-61",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 209.0, 448.0, 91.0, 23.0 ],
					"text" : "prepend open"
				}

			}
, 			{
				"box" : 				{
					"autopopulate" : 1,
					"id" : "obj-62",
					"items" : [ "A-001.mp3", ",", "A-002.mp3", ",", "A-003.mp3", ",", "A-004.mp3", ",", "A-005.mp3", ",", "A-006.mp3", ",", "A-007.mp3", ",", "A-008.mp3", ",", "A-009.mp3", ",", "A-010.mp3", ",", "A-011.mp3", ",", "A-012.mp3", ",", "A-013.mp3", ",", "A-014.mp3", ",", "A-015.mp3", ",", "A-016.mp3", ",", "A-017.mp3", ",", "A-018.mp3", ",", "A-019.mp3", ",", "A-020.mp3", ",", "A-021.mp3", ",", "A-022.mp3", ",", "A-023.mp3", ",", "A-024.mp3", ",", "A-025.mp3", ",", "A-026.mp3", ",", "A-027.mp3", ",", "A-028.mp3", ",", "A-029.mp3", ",", "A-030.mp3", ",", "A-031.mp3", ",", "A-032.mp3", ",", "A-033.mp3", ",", "A-034.mp3", ",", "A-035.mp3", ",", "A-036.mp3", ",", "A-037.mp3", ",", "A-038.mp3", ",", "A-039.mp3", ",", "A-040.mp3", ",", "A-041.mp3", ",", "A-042.mp3", ",", "A-043.mp3", ",", "A-044.mp3", ",", "A-045.mp3", ",", "A-046.mp3", ",", "A-047.mp3", ",", "A-048.mp3", ",", "A-049.mp3", ",", "A-050.mp3", ",", "A-051.mp3", ",", "A-052.mp3", ",", "A-053.mp3", ",", "A-054.mp3", ",", "A-055.mp3", ",", "A-056.mp3", ",", "A-057.mp3", ",", "A-058.mp3", ",", "A-059.mp3", ",", "A-060.mp3", ",", "A-061.mp3", ",", "A-062.mp3", ",", "A-063.mp3", ",", "A-064.mp3", ",", "A-065.mp3", ",", "A-066.mp3", ",", "A-067.mp3", ",", "A-068.mp3", ",", "A-069.mp3", ",", "A-070.mp3", ",", "A-071.mp3", ",", "A-072.mp3", ",", "A-073.mp3", ",", "A-074.mp3", ",", "A-075.mp3", ",", "A-076.mp3", ",", "A-077.mp3", ",", "A-078.mp3", ",", "A-079.mp3", ",", "A-080.mp3", ",", "A-081.mp3", ",", "A-082.mp3", ",", "A-083.mp3", ",", "A-084.mp3", ",", "A-085.mp3", ",", "A-086.mp3", ",", "A-087.mp3", ",", "A-088.mp3", ",", "A-089.mp3", ",", "A-090.mp3", ",", "A-091.mp3", ",", "A-092.mp3", ",", "A-093.mp3", ",", "A-094.mp3", ",", "A-095.mp3", ",", "A-096.mp3", ",", "A-097.mp3", ",", "A-098.mp3", ",", "A-099.mp3", ",", "A-100.mp3", ",", "A-101.mp3", ",", "A-102.mp3", ",", "A-103.mp3", ",", "A-104.mp3", ",", "A-105.mp3", ",", "A-106.mp3", ",", "A-107.mp3", ",", "A-108.mp3", ",", "A-109.mp3", ",", "A-110.mp3", ",", "A-111.mp3", ",", "A-112.mp3", ",", "A-113.mp3", ",", "A-114.mp3", ",", "A-115.mp3", ",", "A-116.mp3", ",", "A-117.mp3", ",", "A-118.mp3", ",", "A-119.mp3", ",", "A-120.mp3", ",", "A-121.mp3", ",", "A-122.mp3", ",", "A-123.mp3", ",", "A-124.mp3", ",", "A-125.mp3", ",", "A-126.mp3", ",", "A-127.mp3", ",", "A-128.mp3", ",", "A-129.mp3", ",", "A-130.mp3", ",", "A-131.mp3", ",", "A-132.mp3", ",", "A-133.mp3", ",", "A-134.mp3", ",", "A-135.mp3", ",", "A-136.mp3", ",", "A-137.mp3", ",", "A-138.mp3", ",", "A-139.mp3", ",", "A-140.mp3", ",", "A-141.mp3", ",", "A-142.mp3", ",", "A-143.mp3", ",", "A-144.mp3", ",", "A-145.mp3", ",", "A-146.mp3", ",", "A-147.mp3", ",", "A-148.mp3", ",", "A-149.mp3", ",", "A-150.mp3", ",", "A-151.mp3", ",", "A-152.mp3", ",", "A-153.mp3", ",", "A-154.mp3", ",", "A-155.mp3", ",", "A-156.mp3", ",", "A-157.mp3", ",", "A-158.mp3", ",", "A-159.mp3", ",", "A-160.mp3", ",", "A-161.mp3", ",", "A-162.mp3", ",", "A-163.mp3", ",", "A-164.mp3", ",", "A-165.mp3", ",", "A-166.mp3", ",", "A-167.mp3", ",", "A-168.mp3", ",", "A-169.mp3", ",", "A-170.mp3", ",", "A-171.mp3", ",", "A-172.mp3", ",", "A-173.mp3", ",", "A-174.mp3", ",", "A-175.mp3", ",", "A-176.mp3", ",", "A-177.mp3", ",", "A-178.mp3", ",", "A-179.mp3", ",", "A-180.mp3", ",", "A-181.mp3", ",", "A-182.mp3", ",", "A-183.mp3", ",", "A-184.mp3", ",", "A-185.mp3", ",", "A-186.mp3", ",", "A-187.mp3", ",", "A-188.mp3", ",", "A-189.mp3", ",", "A-190.mp3", ",", "A-191.mp3", ",", "A-192.mp3", ",", "A-193.mp3", ",", "A-194.mp3", ",", "A-195.mp3", ",", "A-196.mp3", ",", "A-197.mp3", ",", "A-198.mp3", ",", "A-199.mp3", ",", "A-200.mp3", ",", "A-201.mp3", ",", "A-202.mp3", ",", "A-203.mp3", ",", "A-204.mp3", ",", "A-205.mp3", ",", "A-206.mp3", ",", "A-207.mp3", ",", "A-208.mp3", ",", "A-209.mp3", ",", "A-210.mp3", ",", "A-211.mp3", ",", "A-212.mp3", ",", "A-213.mp3", ",", "A-214.mp3", ",", "A-215.mp3", ",", "A-216.mp3", ",", "A-217.mp3", ",", "A-218.mp3", ",", "A-219.mp3", ",", "A-220.mp3", ",", "A-221.mp3", ",", "A-222.mp3", ",", "A-223.mp3", ",", "A-224.mp3", ",", "A-225.mp3", ",", "A-226.mp3", ",", "A-227.mp3", ",", "A-228.mp3", ",", "A-229.mp3", ",", "A-230.mp3", ",", "A-231.mp3", ",", "A-232.mp3", ",", "A-233.mp3", ",", "A-234.mp3", ",", "A-235.mp3", ",", "A-236.mp3", ",", "A-237.mp3", ",", "A-238.mp3", ",", "A-239.mp3", ",", "A-240.mp3", ",", "A-241.mp3", ",", "A-242.mp3", ",", "A-243.mp3", ",", "A-244.mp3", ",", "A-245.mp3", ",", "A-246.mp3", ",", "A-247.mp3", ",", "A-248.mp3", ",", "A-249.mp3", ",", "A-250.mp3", ",", "A-251.mp3", ",", "A-252.mp3", ",", "A-253.mp3", ",", "A-254.mp3", ",", "A-255.mp3", ",", "A-256.mp3", ",", "A-257.mp3", ",", "A-258.mp3", ",", "A-259.mp3", ",", "A-260.mp3", ",", "A-261.mp3", ",", "A-262.mp3", ",", "A-263.mp3", ",", "A-264.mp3", ",", "A-265.mp3", ",", "A-266.mp3", ",", "A-267.mp3", ",", "A-268.mp3", ",", "A-269.mp3", ",", "A-270.mp3", ",", "A-271.mp3", ",", "A-272.mp3", ",", "A-273.mp3", ",", "A-274.mp3", ",", "A-275.mp3", ",", "A-276.mp3", ",", "A-277.mp3", ",", "A-278.mp3", ",", "A-279.mp3", ",", "A-280.mp3", ",", "A-281.mp3", ",", "A-282.mp3", ",", "A-283.mp3", ",", "A-284.mp3", ",", "A-285.mp3", ",", "A-286.mp3", ",", "A-287.mp3", ",", "A-288.mp3", ",", "A-289.mp3", ",", "A-290.mp3", ",", "A-291.mp3", ",", "A-292.mp3", ",", "A-293.mp3", ",", "A-294.mp3", ",", "A-295.mp3", ",", "A-296.mp3", ",", "A-297.mp3", ",", "A-298.mp3", ",", "A-299.mp3", ",", "A-300.mp3", ",", "A-301.mp3", ",", "A-302.mp3", ",", "A-303.mp3", ",", "A-304.mp3", ",", "A-305.mp3", ",", "A-306.mp3", ",", "A-307.mp3", ",", "A-308.mp3", ",", "A-309.mp3", ",", "A-310.mp3", ",", "A-311.mp3", ",", "A-312.mp3", ",", "A-313.mp3", ",", "A-314.mp3", ",", "A-315.mp3", ",", "A-316.mp3", ",", "A-317.mp3", ",", "A-318.mp3", ",", "A-319.mp3", ",", "A-320.mp3", ",", "A-321.mp3", ",", "A-322.mp3", ",", "A-323.mp3", ",", "A-324.mp3", ",", "A-325.mp3", ",", "A-326.mp3", ",", "A-327.mp3", ",", "A-328.mp3", ",", "A-329.mp3", ",", "A-330.mp3", ",", "A-331.mp3", ",", "A-332.mp3", ",", "A-333.mp3", ",", "A-334.mp3", ",", "A-335.mp3", ",", "A-336.mp3", ",", "A-337.mp3", ",", "A-338.mp3", ",", "A-339.mp3", ",", "A-340.mp3", ",", "A-341.mp3", ",", "A-342.mp3", ",", "A-343.mp3", ",", "A-344.mp3", ",", "A-345.mp3", ",", "A-346.mp3", ",", "A-347.mp3", ",", "A-348.mp3", ",", "A-349.mp3", ",", "A-350.mp3", ",", "A-351.mp3", ",", "A-352.mp3", ",", "A-353.mp3", ",", "A-354.mp3", ",", "A-355.mp3", ",", "A-356.mp3", ",", "A-357.mp3", ",", "A-358.mp3", ",", "A-359.mp3", ",", "A-360.mp3", ",", "A-361.mp3", ",", "A-362.mp3", ",", "A-363.mp3", ",", "A-364.mp3", ",", "A-365.mp3", ",", "A-366.mp3", ",", "A-367.mp3", ",", "A-368.mp3", ",", "A-369.mp3", ",", "A-370.mp3", ",", "A-371.mp3", ",", "A-372.mp3", ",", "A-373.mp3", ",", "A-374.mp3", ",", "A-375.mp3", ",", "A-376.mp3", ",", "A-377.mp3", ",", "A-378.mp3", ",", "A-379.mp3", ",", "A-380.mp3", ",", "A-381.mp3", ",", "A-382.mp3", ",", "A-383.mp3", ",", "A-384.mp3", ",", "A-385.mp3", ",", "A-386.mp3", ",", "A-387.mp3", ",", "A-388.mp3", ",", "A-389.mp3", ",", "A-390.mp3", ",", "A-391.mp3", ",", "A-392.mp3", ",", "A-393.mp3", ",", "A-394.mp3", ",", "A-395.mp3", ",", "A-396.mp3", ",", "A-397.mp3", ",", "A-398.mp3", ",", "A-399.mp3", ",", "A-400.mp3", ",", "A-401.mp3", ",", "A-402.mp3", ",", "A-403.mp3", ",", "A-404.mp3", ",", "A-405.mp3", ",", "A-406.mp3", ",", "A-407.mp3", ",", "A-408.mp3", ",", "A-409.mp3", ",", "A-410.mp3", ",", "A-411.mp3", ",", "A-412.mp3", ",", "A-413.mp3", ",", "A-414.mp3", ",", "A-415.mp3", ",", "A-416.mp3", ",", "A-417.mp3", ",", "A-418.mp3", ",", "A-419.mp3", ",", "A-420.mp3", ",", "A-421.mp3", ",", "A-422.mp3", ",", "A-423.mp3", ",", "A-424.mp3", ",", "A-425.mp3", ",", "A-426.mp3", ",", "A-427.mp3", ",", "A-428.mp3", ",", "A-429.mp3", ",", "A-430.mp3", ",", "A-431.mp3", ",", "A-432.mp3", ",", "A-433.mp3", ",", "A-434.mp3", ",", "A-435.mp3", ",", "A-436.mp3", ",", "A-437.mp3", ",", "A-438.mp3", ",", "A-439.mp3", ",", "A-440.mp3", ",", "A-441.mp3", ",", "A-442.mp3", ",", "A-443.mp3", ",", "A-444.mp3", ",", "A-445.mp3", ",", "A-446.mp3", ",", "A-447.mp3", ",", "A-448.mp3", ",", "A-449.mp3", ",", "A-450.mp3", ",", "A-451.mp3", ",", "A-452.mp3", ",", "A-453.mp3", ",", "A-454.mp3", ",", "A-455.mp3", ",", "A-456.mp3", ",", "A-457.mp3", ",", "A-458.mp3", ",", "A-459.mp3", ",", "A-460.mp3", ",", "A-461.mp3", ",", "A-462.mp3", ",", "A-463.mp3", ",", "A-464.mp3", ",", "A-465.mp3", ",", "A-466.mp3", ",", "A-467.mp3", ",", "A-468.mp3", ",", "A-469.mp3", ",", "A-470.mp3", ",", "A-471.mp3", ",", "A-472.mp3", ",", "A-473.mp3", ",", "A-474.mp3", ",", "A-475.mp3", ",", "A-476.mp3", ",", "A-477.mp3", ",", "A-478.mp3", ",", "A-479.mp3", ",", "A-480.mp3", ",", "A-481.mp3", ",", "A-482.mp3", ",", "A-483.mp3", ",", "A-484.mp3", ",", "A-485.mp3", ",", "A-486.mp3", ",", "A-487.mp3", ",", "A-488.mp3", ",", "A-489.mp3", ",", "A-490.mp3", ",", "A-491.mp3", ",", "A.mp3" ],
					"maxclass" : "umenu",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "int", "", "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 209.0, 415.0, 399.0, 22.0 ],
					"prefix" : "Z:/",
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 176.190498769283295, 399.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontface" : 0,
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-63",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 209.0, 374.0, 224.0, 23.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 148.571447610855103, 118.0, 23.0 ],
					"text" : "loadmess prefix Z:/"
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-64",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "signal", "bang" ],
					"patching_rect" : [ 209.0, 519.0, 53.0, 23.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 252.0, 91.0, 23.0 ],
					"text" : "sfplay~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-65",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "", "" ],
					"patching_rect" : [ 236.0, 232.0, 77.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 72.0, 77.0, 22.0 ],
					"text" : "route /plays1"
				}

			}
, 			{
				"box" : 				{
					"bgcolor" : [ 1.0, 0.788235, 0.470588, 1.0 ],
					"fontname" : "Arial Bold",
					"hint" : "",
					"id" : "obj-23",
					"ignoreclick" : 1,
					"legacytextcolor" : 1,
					"maxclass" : "textbutton",
					"numinlets" : 1,
					"numoutlets" : 3,
					"outlettype" : [ "", "", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 227.0, 1929.0, 20.0, 20.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 190.0, 110.0, 20.0, 20.0 ],
					"rounded" : 60.0,
					"text" : "1",
					"textcolor" : [ 0.34902, 0.34902, 0.34902, 1.0 ]
				}

			}
, 			{
				"box" : 				{
					"bubble" : 1,
					"fontname" : "Arial",
					"fontsize" : 13.0,
					"id" : "obj-26",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 116.0, 1929.0, 108.0, 25.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 77.0, 108.0, 108.0, 25.0 ],
					"text" : "turn on audio"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-10",
					"local" : 1,
					"maxclass" : "ezdac~",
					"numinlets" : 2,
					"numoutlets" : 0,
					"patching_rect" : [ 58.0, 1918.0, 45.0, 45.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 98.0, 45.0, 45.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-16",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 295.0, 843.0, 29.5, 22.0 ],
					"text" : "*~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-20",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 263.0, 843.0, 29.5, 22.0 ],
					"text" : "*~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-12",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1033.0, 418.0, 70.0, 22.0 ],
					"text" : "loadmess 0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-21",
					"markers" : [ -60, -48, -36, -24, -12, -6, 0, 6 ],
					"markersused" : 8,
					"maxclass" : "levelmeter~",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 270.0, 1907.0, 128.0, 64.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 34.0, 1043.0, 133.0, 66.5 ]
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-38",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 35.0, 1069.0, 98.462086847850287, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 61.0, 844.0, 175.0, 27.0 ],
					"text" : "dry volume"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-37",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 35.0, 636.0, 24.0, 24.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 30.0, 843.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-35",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 35.0, 941.0, 40.0, 22.0 ],
					"text" : "r~ dry"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-34",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 35.0, 710.0, 42.0, 22.0 ],
					"text" : "s~ dry"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-17",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 35.0, 678.0, 39.0, 22.0 ],
					"text" : "gate~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-32",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1103.0, 549.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-31",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"patching_rect" : [ 1103.0, 503.0, 33.0, 22.0 ],
					"text" : "== 0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-36",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1264.0, 564.0, 39.0, 22.0 ],
					"text" : "gate~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-39",
					"maxclass" : "newobj",
					"numinlets" : 2,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1137.0, 564.0, 39.0, 22.0 ],
					"text" : "gate~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-40",
					"maxclass" : "toggle",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1103.0, 464.0, 24.0, 24.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 527.0, 840.0, 24.0, 24.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-41",
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 946.0, 388.0, 156.752336919307709, 27.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 555.0, 840.0, 184.0, 27.0 ],
					"text" : "enable modulation"
				}

			}
, 			{
				"box" : 				{
					"fontsize" : 18.0,
					"id" : "obj-42",
					"linecount" : 2,
					"maxclass" : "comment",
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 263.0, 689.0, 165.432111978530884, 48.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 184.0, 375.0, 180.0, 27.0 ],
					"text" : "<--- 5. enable this (x)"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-45",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1285.0, 533.0, 41.0, 22.0 ],
					"text" : "sig~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-46",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1285.0, 503.0, 107.0, 22.0 ],
					"text" : "scale 0. 127. -3. 3."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-47",
					"maxclass" : "newobj",
					"numinlets" : 6,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 1157.0, 503.0, 107.0, 22.0 ],
					"text" : "scale 0. 127. -3. 3."
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-48",
					"maxclass" : "pictslider",
					"numinlets" : 2,
					"numoutlets" : 2,
					"outlettype" : [ "int", "int" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 1157.0, 367.0, 147.0, 125.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 404.0, 840.0, 116.0, 94.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-49",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 1157.0, 533.0, 41.0, 22.0 ],
					"text" : "sig~"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-50",
					"maxclass" : "newobj",
					"numinlets" : 8,
					"numoutlets" : 1,
					"outlettype" : [ "signal" ],
					"patching_rect" : [ 263.0, 938.0, 237.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 30.0, 435.0, 252.459009170532227, 22.0 ],
					"text" : "nn~ magnets_b2048_r48000_z8.ts decode"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-55",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 103.0, 658.0, 70.0, 22.0 ],
					"text" : "loadmess 0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-56",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 8,
					"outlettype" : [ "signal", "signal", "signal", "signal", "signal", "signal", "signal", "signal" ],
					"patching_rect" : [ 592.0, 701.0, 237.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 407.0, 278.688516616821289, 22.0 ],
					"text" : "nn~ magnets_b2048_r48000_z8.ts encode"
				}

			}
, 			{
				"box" : 				{
					"attr" : "enable",
					"id" : "obj-57",
					"maxclass" : "attrui",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 103.0, 689.0, 150.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 378.0, 150.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"fontname" : "Arial",
					"fontsize" : 12.0,
					"id" : "obj-51",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 5,
					"outlettype" : [ "", "", "", "", "" ],
					"patching_rect" : [ 235.0, 114.0, 151.0, 22.0 ],
					"text" : "regexp \\\\s @substitute %0"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-29",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 409.0, 34.0, 50.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 238.0, 11.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-22",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 340.0, 34.0, 50.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 169.0, 11.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-11",
					"maxclass" : "newobj",
					"numinlets" : 7,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 235.0, 81.0, 82.0, 22.0 ],
					"text" : "pak i . i . i . i"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-9",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 271.0, 34.0, 50.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 100.0, 11.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-5",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 200.0, 34.0, 50.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 11.0, 50.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-33",
					"maxclass" : "number",
					"numinlets" : 1,
					"numoutlets" : 2,
					"outlettype" : [ "", "bang" ],
					"parameter_enable" : 0,
					"patching_rect" : [ 423.0, 114.0, 50.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 352.0, 11.0, 60.0, 22.0 ]
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-28",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 358.0, 150.0, 77.0, 22.0 ],
					"text" : "prepend port"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-19",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 236.0, 150.0, 79.0, 22.0 ],
					"text" : "prepend host"
				}

			}
, 			{
				"box" : 				{
					"id" : "obj-2",
					"maxclass" : "newobj",
					"numinlets" : 1,
					"numoutlets" : 1,
					"outlettype" : [ "" ],
					"patching_rect" : [ 236.0, 183.0, 151.0, 22.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 29.0, 46.0, 97.0, 22.0 ],
					"text" : "udpreceive 8888"
				}

			}
, 			{
				"box" : 				{
					"angle" : 270.0,
					"bgcolor" : [ 0.835294117647059, 0.517647058823529, 0.850980392156863, 0.48 ],
					"bordercolor" : [ 0.807843137254902, 0.898039215686275, 0.909803921568627, 0.0 ],
					"id" : "obj-44",
					"maxclass" : "panel",
					"mode" : 0,
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1480.0, 224.0, 128.0, 128.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 13.5, 2.0, 734.92620849609375, 358.0 ],
					"proportion" : 0.5
				}

			}
, 			{
				"box" : 				{
					"angle" : 270.0,
					"bgcolor" : [ 0.517647058823529, 0.796078431372549, 0.850980392156863, 0.48 ],
					"bordercolor" : [ 0.807843137254902, 0.898039215686275, 0.909803921568627, 0.0 ],
					"id" : "obj-24",
					"maxclass" : "panel",
					"mode" : 0,
					"numinlets" : 1,
					"numoutlets" : 0,
					"patching_rect" : [ 1480.0, 362.0, 128.0, 128.0 ],
					"presentation" : 1,
					"presentation_rect" : [ 14.0, 370.0, 734.42620849609375, 763.934404373168945 ],
					"proportion" : 0.5
				}

			}
 ],
		"lines" : [ 			{
				"patchline" : 				{
					"destination" : [ "obj-159", 0 ],
					"source" : [ "obj-1", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-159", 0 ],
					"source" : [ "obj-1", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-64", 0 ],
					"source" : [ "obj-100", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-108", 0 ],
					"source" : [ "obj-102", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-117", 0 ],
					"source" : [ "obj-103", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-103", 0 ],
					"source" : [ "obj-104", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-110", 0 ],
					"order" : 2,
					"source" : [ "obj-105", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-111", 0 ],
					"order" : 0,
					"source" : [ "obj-105", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-99", 0 ],
					"order" : 1,
					"source" : [ "obj-105", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-122", 0 ],
					"source" : [ "obj-106", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-48", 0 ],
					"source" : [ "obj-107", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-48", 1 ],
					"source" : [ "obj-108", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-51", 0 ],
					"source" : [ "obj-11", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-40", 0 ],
					"source" : [ "obj-110", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-102", 0 ],
					"order" : 0,
					"source" : [ "obj-111", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-18", 0 ],
					"order" : 1,
					"source" : [ "obj-111", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-106", 0 ],
					"source" : [ "obj-112", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-99", 1 ],
					"source" : [ "obj-114", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-62", 0 ],
					"source" : [ "obj-115", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-115", 0 ],
					"source" : [ "obj-116", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-62", 0 ],
					"order" : 0,
					"source" : [ "obj-116", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-63", 0 ],
					"order" : 1,
					"source" : [ "obj-116", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-134", 0 ],
					"source" : [ "obj-117", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-116", 0 ],
					"source" : [ "obj-118", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-40", 0 ],
					"source" : [ "obj-12", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-121", 0 ],
					"source" : [ "obj-120", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-115", 0 ],
					"source" : [ "obj-121", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-124", 0 ],
					"order" : 0,
					"source" : [ "obj-121", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-62", 0 ],
					"source" : [ "obj-121", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-7", 0 ],
					"order" : 1,
					"source" : [ "obj-121", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 1 ],
					"order" : 0,
					"source" : [ "obj-122", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 0 ],
					"order" : 1,
					"source" : [ "obj-122", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-118", 0 ],
					"source" : [ "obj-124", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-141", 1 ],
					"source" : [ "obj-125", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-141", 0 ],
					"source" : [ "obj-125", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-127", 0 ],
					"source" : [ "obj-126", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-130", 0 ],
					"order" : 0,
					"source" : [ "obj-128", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-132", 0 ],
					"order" : 1,
					"source" : [ "obj-128", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-106", 5 ],
					"source" : [ "obj-129", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 1 ],
					"order" : 0,
					"source" : [ "obj-13", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 0 ],
					"order" : 1,
					"source" : [ "obj-13", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 1 ],
					"order" : 0,
					"source" : [ "obj-130", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 0 ],
					"order" : 1,
					"source" : [ "obj-130", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 1 ],
					"order" : 0,
					"source" : [ "obj-131", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 0 ],
					"order" : 1,
					"source" : [ "obj-131", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-122", 0 ],
					"source" : [ "obj-134", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-145", 0 ],
					"source" : [ "obj-135", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-131", 0 ],
					"source" : [ "obj-136", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-136", 0 ],
					"source" : [ "obj-137", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-135", 0 ],
					"source" : [ "obj-138", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-138", 0 ],
					"source" : [ "obj-139", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-116", 1 ],
					"order" : 0,
					"source" : [ "obj-14", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-62", 0 ],
					"source" : [ "obj-14", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-63", 0 ],
					"order" : 1,
					"source" : [ "obj-14", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-7", 0 ],
					"source" : [ "obj-14", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-145", 0 ],
					"source" : [ "obj-140", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-10", 1 ],
					"order" : 1,
					"source" : [ "obj-141", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-10", 0 ],
					"order" : 1,
					"source" : [ "obj-141", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-21", 0 ],
					"order" : 0,
					"source" : [ "obj-141", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-21", 0 ],
					"order" : 0,
					"source" : [ "obj-141", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-134", 0 ],
					"source" : [ "obj-142", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-141", 0 ],
					"source" : [ "obj-143", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-142", 0 ],
					"source" : [ "obj-144", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-131", 0 ],
					"source" : [ "obj-145", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-140", 0 ],
					"source" : [ "obj-146", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 1 ],
					"order" : 0,
					"source" : [ "obj-147", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 0 ],
					"order" : 1,
					"source" : [ "obj-147", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-154", 0 ],
					"source" : [ "obj-148", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-100", 0 ],
					"source" : [ "obj-149", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-63", 0 ],
					"source" : [ "obj-15", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-167", 0 ],
					"source" : [ "obj-150", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-165", 0 ],
					"source" : [ "obj-152", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-147", 0 ],
					"source" : [ "obj-154", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-166", 0 ],
					"source" : [ "obj-155", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-160", 1 ],
					"order" : 0,
					"source" : [ "obj-157", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-160", 0 ],
					"order" : 1,
					"source" : [ "obj-157", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-160", 0 ],
					"source" : [ "obj-158", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-85", 0 ],
					"source" : [ "obj-159", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 1 ],
					"source" : [ "obj-16", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-104", 0 ],
					"order" : 1,
					"source" : [ "obj-160", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-171", 0 ],
					"source" : [ "obj-160", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-173", 0 ],
					"order" : 0,
					"source" : [ "obj-160", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 5 ],
					"source" : [ "obj-161", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 3 ],
					"source" : [ "obj-162", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-3", 1 ],
					"order" : 0,
					"source" : [ "obj-164", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-3", 0 ],
					"order" : 1,
					"source" : [ "obj-164", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-148", 0 ],
					"source" : [ "obj-165", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-154", 0 ],
					"source" : [ "obj-166", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 1 ],
					"order" : 1,
					"source" : [ "obj-167", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 0 ],
					"order" : 2,
					"source" : [ "obj-167", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-147", 0 ],
					"order" : 0,
					"source" : [ "obj-167", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-34", 0 ],
					"source" : [ "obj-17", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-171", 1 ],
					"order" : 1,
					"source" : [ "obj-170", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-173", 1 ],
					"order" : 0,
					"source" : [ "obj-170", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-148", 0 ],
					"source" : [ "obj-171", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-148", 0 ],
					"source" : [ "obj-173", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-166", 5 ],
					"source" : [ "obj-179", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-107", 0 ],
					"source" : [ "obj-18", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-2", 0 ],
					"source" : [ "obj-19", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-120", 0 ],
					"order" : 0,
					"source" : [ "obj-2", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-126", 0 ],
					"order" : 2,
					"source" : [ "obj-2", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-65", 0 ],
					"order" : 1,
					"source" : [ "obj-2", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 0 ],
					"source" : [ "obj-20", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 4 ],
					"source" : [ "obj-22", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-143", 0 ],
					"source" : [ "obj-25", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-117", 0 ],
					"source" : [ "obj-27", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-2", 0 ],
					"source" : [ "obj-28", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 6 ],
					"source" : [ "obj-29", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 0 ],
					"source" : [ "obj-3", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-78", 0 ],
					"source" : [ "obj-3", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-98", 0 ],
					"source" : [ "obj-30", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-32", 0 ],
					"source" : [ "obj-31", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-28", 0 ],
					"source" : [ "obj-33", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 1 ],
					"order" : 0,
					"source" : [ "obj-35", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 0 ],
					"order" : 1,
					"source" : [ "obj-35", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-16", 1 ],
					"order" : 2,
					"source" : [ "obj-36", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-161", 1 ],
					"order" : 0,
					"source" : [ "obj-36", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-81", 1 ],
					"order" : 1,
					"source" : [ "obj-36", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-17", 0 ],
					"source" : [ "obj-37", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-162", 1 ],
					"order" : 0,
					"source" : [ "obj-39", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-20", 1 ],
					"order" : 2,
					"source" : [ "obj-39", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-84", 1 ],
					"order" : 1,
					"source" : [ "obj-39", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-59", 0 ],
					"source" : [ "obj-4", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-31", 0 ],
					"order" : 2,
					"source" : [ "obj-40", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-36", 0 ],
					"order" : 0,
					"source" : [ "obj-40", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-39", 0 ],
					"order" : 1,
					"source" : [ "obj-40", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-116", 1 ],
					"order" : 0,
					"source" : [ "obj-43", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-63", 0 ],
					"order" : 2,
					"source" : [ "obj-43", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-65", 0 ],
					"order" : 1,
					"source" : [ "obj-43", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-36", 1 ],
					"source" : [ "obj-45", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-45", 0 ],
					"midpoints" : [ 1294.5, 526.473638892173767, 1294.5, 526.473638892173767 ],
					"source" : [ "obj-46", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-49", 0 ],
					"midpoints" : [ 1166.5, 526.448950886726379, 1166.5, 526.448950886726379 ],
					"source" : [ "obj-47", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-129", 0 ],
					"order" : 1,
					"source" : [ "obj-48", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-179", 0 ],
					"order" : 0,
					"source" : [ "obj-48", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-46", 0 ],
					"midpoints" : [ 1294.5, 498.38721489906311, 1294.5, 498.38721489906311 ],
					"order" : 1,
					"source" : [ "obj-48", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-47", 0 ],
					"midpoints" : [ 1166.5, 496.448950886726379, 1166.5, 496.448950886726379 ],
					"order" : 0,
					"source" : [ "obj-48", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-39", 1 ],
					"source" : [ "obj-49", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 0 ],
					"source" : [ "obj-5", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-75", 1 ],
					"order" : 0,
					"source" : [ "obj-50", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-75", 0 ],
					"order" : 1,
					"source" : [ "obj-50", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-19", 0 ],
					"source" : [ "obj-51", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-57", 0 ],
					"midpoints" : [ 112.5, 681.135030269622803, 112.5, 681.135030269622803 ],
					"source" : [ "obj-55", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 7 ],
					"order" : 0,
					"source" : [ "obj-56", 7 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 6 ],
					"order" : 0,
					"source" : [ "obj-56", 6 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 4 ],
					"order" : 0,
					"source" : [ "obj-56", 4 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 2 ],
					"order" : 0,
					"source" : [ "obj-56", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 1 ],
					"order" : 0,
					"source" : [ "obj-56", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 0 ],
					"order" : 0,
					"source" : [ "obj-56", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-16", 0 ],
					"order" : 2,
					"source" : [ "obj-56", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-161", 0 ],
					"order" : 0,
					"source" : [ "obj-56", 5 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-162", 0 ],
					"order" : 0,
					"source" : [ "obj-56", 3 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 7 ],
					"order" : 1,
					"source" : [ "obj-56", 7 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 6 ],
					"order" : 1,
					"source" : [ "obj-56", 6 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 5 ],
					"order" : 1,
					"source" : [ "obj-56", 5 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 4 ],
					"order" : 1,
					"source" : [ "obj-56", 4 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 2 ],
					"order" : 1,
					"source" : [ "obj-56", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 1 ],
					"order" : 1,
					"source" : [ "obj-56", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-20", 0 ],
					"order" : 2,
					"source" : [ "obj-56", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 7 ],
					"order" : 2,
					"source" : [ "obj-56", 7 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 6 ],
					"order" : 2,
					"source" : [ "obj-56", 6 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 5 ],
					"order" : 2,
					"source" : [ "obj-56", 5 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 4 ],
					"order" : 2,
					"source" : [ "obj-56", 4 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 3 ],
					"order" : 2,
					"source" : [ "obj-56", 3 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 2 ],
					"order" : 2,
					"source" : [ "obj-56", 2 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-81", 0 ],
					"order" : 1,
					"source" : [ "obj-56", 3 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-84", 0 ],
					"order" : 1,
					"source" : [ "obj-56", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-157", 0 ],
					"order" : 0,
					"source" : [ "obj-57", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 0 ],
					"order" : 1,
					"source" : [ "obj-57", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-50", 0 ],
					"midpoints" : [ 112.5, 879.672413229942322, 272.5, 879.672413229942322 ],
					"order" : 3,
					"source" : [ "obj-57", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-56", 0 ],
					"midpoints" : [ 112.5, 730.235306590795517, 601.5, 730.235306590795517 ],
					"order" : 2,
					"source" : [ "obj-57", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-17", 1 ],
					"order" : 1,
					"source" : [ "obj-59", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-56", 0 ],
					"source" : [ "obj-59", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-56", 0 ],
					"order" : 0,
					"source" : [ "obj-59", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-64", 0 ],
					"midpoints" : [ 311.5, 510.452605009078979, 218.5, 510.452605009078979 ],
					"source" : [ "obj-60", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-64", 0 ],
					"source" : [ "obj-61", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-61", 0 ],
					"source" : [ "obj-62", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-62", 0 ],
					"source" : [ "obj-63", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-59", 1 ],
					"order" : 0,
					"source" : [ "obj-64", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-59", 0 ],
					"order" : 1,
					"source" : [ "obj-64", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-83", 0 ],
					"source" : [ "obj-64", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-8", 0 ],
					"source" : [ "obj-65", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-64", 0 ],
					"source" : [ "obj-7", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-73", 0 ],
					"source" : [ "obj-70", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-86", 0 ],
					"source" : [ "obj-72", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-72", 0 ],
					"source" : [ "obj-73", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-75", 0 ],
					"source" : [ "obj-74", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-135", 0 ],
					"source" : [ "obj-75", 1 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-135", 0 ],
					"source" : [ "obj-75", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-27", 1 ],
					"order" : 0,
					"source" : [ "obj-76", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-78", 1 ],
					"order" : 1,
					"source" : [ "obj-76", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-3", 0 ],
					"source" : [ "obj-77", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-117", 0 ],
					"source" : [ "obj-78", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-1", 0 ],
					"source" : [ "obj-79", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-14", 0 ],
					"source" : [ "obj-8", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 3 ],
					"source" : [ "obj-81", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-164", 0 ],
					"source" : [ "obj-84", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 1 ],
					"order" : 0,
					"source" : [ "obj-85", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-125", 0 ],
					"order" : 1,
					"source" : [ "obj-85", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-87", 0 ],
					"source" : [ "obj-86", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-88", 0 ],
					"order" : 1,
					"source" : [ "obj-87", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-89", 0 ],
					"order" : 0,
					"source" : [ "obj-87", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-92", 0 ],
					"source" : [ "obj-88", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-93", 0 ],
					"source" : [ "obj-89", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-11", 2 ],
					"source" : [ "obj-9", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-91", 0 ],
					"source" : [ "obj-92", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-94", 0 ],
					"source" : [ "obj-93", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-85", 1 ],
					"source" : [ "obj-98", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-102", 0 ],
					"order" : 0,
					"source" : [ "obj-99", 0 ]
				}

			}
, 			{
				"patchline" : 				{
					"destination" : [ "obj-18", 0 ],
					"order" : 1,
					"source" : [ "obj-99", 0 ]
				}

			}
 ],
		"parameters" : 		{
			"obj-1" : [ "live.gain~[2]", "live.gain~", 0 ],
			"obj-125" : [ "live.gain~[4]", "live.gain~", 0 ],
			"obj-160" : [ "live.gain~[6]", "live.gain~", 0 ],
			"obj-3" : [ "live.gain~[3]", "live.gain~", 0 ],
			"obj-59" : [ "live.gain~[1]", "live.gain~", 0 ],
			"obj-75" : [ "live.gain~[5]", "live.gain~", 0 ],
			"parameterbanks" : 			{
				"0" : 				{
					"index" : 0,
					"name" : "",
					"parameters" : [ "-", "-", "-", "-", "-", "-", "-", "-" ]
				}

			}
,
			"inherited_shortname" : 1
		}
,
		"dependency_cache" : [ 			{
				"name" : "nn~.mxe64",
				"type" : "mx64"
			}
 ],
		"autosave" : 0
	}

}
