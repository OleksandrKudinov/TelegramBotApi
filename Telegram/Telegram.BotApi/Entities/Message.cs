using System;
using Telegram.BotApi.Internal.BindingModels;

namespace Telegram.BotApi.Entities
{
    public abstract class Message
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        public long MessageId { get; set; }

        /// <summary>
        /// Optional. Sender, can be empty for messages sent to channels
        /// </summary>
        public UserDTO FromUser { get; set; }

        /// <summary>
        /// Date the message was sent in Unix time (fixed to DateTime)
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Conversation the message belongs to
        /// </summary>
        public ChatDTO Chat { get; set; }

        /// <summary>
        /// Optional. For forwarded messages, sender of the original message
        /// </summary>
        public UserDTO ForwardFromUser { get; set; }

        /// <summary>
        /// Optional. For messages forwarded from a channel, information about the original channel
        /// </summary>
        public ChatDTO ForwardFromChat { get; set; }

        /// <summary>
        /// Optional. For forwarded messages, date the original message was sent in Unix time (fixed to DateTime)
        /// </summary>
        public DateTime? ForwardDate { get; set; }

        /// <summary>
        /// Optional. For replies, the original message. 
        /// Note that the Message object in this field will not contain further
        /// reply_to_message fields even if it itself is a reply.
        /// </summary>
        public Message ReplyToMessage { get; set; }

        /// <summary>
        /// Optional. Date the message was last edited in Unix time (fixed to DateTime)
        /// </summary>
        public DateTime? EditDate { get; set; }

        /// <summary>
        /// Optional. For text messages, special entities like usernames,
        /// URLs, bot commands, etc. that appear in the text
        /// </summary>
        // TODO 
        public MessageEntityDTO[] Entities { get; set; }
    }
}
