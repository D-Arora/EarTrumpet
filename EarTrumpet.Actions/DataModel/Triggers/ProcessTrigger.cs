﻿using EarTrumpet_Actions.DataModel.Enum;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EarTrumpet_Actions.DataModel.Triggers
{
    public class ProcessTrigger : BaseTrigger, IPartWithText
    {
        public string Text { get; set; }

        [XmlIgnore]
        public string PromptText => Properties.Resources.ProcessTriggerDescriptonPromptText;
        public string EmptyText => Properties.Resources.ProcessConditionEmptyText;
        public ProcessEventKind Option { get; set; }

        public ProcessTrigger()
        {
            Description = Properties.Resources.ProcessTriggerDescriptonText;
            Options = new List<OptionCollection>(new OptionCollection[]{ new OptionCollection(new List<Option>
                {
                    new Option(Properties.Resources.ProcessEventKindStartsText, ProcessEventKind.Start),
                    new Option(Properties.Resources.ProcessEventKindStopsText, ProcessEventKind.Stop),
                },
                (newValue) => Option = (ProcessEventKind)newValue.Value,
                () => Option) });
        }

        public override string Describe() => Properties.Resources.ProcessTriggerDescribeFormatText;
    }
}