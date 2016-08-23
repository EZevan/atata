﻿namespace Atata.KendoUI
{
    [ControlDefinition("tr[parent::table or parent::tbody][not(@class) or @class!='k-grouping-row']", ComponentTypeName = "row")]
    [FindByColumnHeaderSettings(Strategy = typeof(KendoGridFindByColumnHeaderStrategy))]
    public class KendoGridRow<TOwner> : TableRow<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
