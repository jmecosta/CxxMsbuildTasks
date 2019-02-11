﻿namespace MsbuildUtilityHelpers.Test

open NUnit.Framework
open MsbuildUtilityHelpers

type MsbuildUtilityHelpersTest() = 

    [<Test>]
    member test.``Ask Non Existent Program Should Return False`` () = 
        let utils = new Utils()
        Assert.That(utils.ExistsOnPath("Askxkjjhazjsdjsz.exe"), Is.False)

    [<Test>]
    member test.``Notepad should exist on path`` () = 
        let utils = new Utils()
        Assert.That(utils.ExistsOnPath("Notepad.exe"), Is.True)


