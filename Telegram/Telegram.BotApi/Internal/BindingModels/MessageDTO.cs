using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class MessageDTO
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonProperty(PropertyName = "message_id")]
        public long MessageId { get; set; }

        /// <summary>
        /// Optional. Sender, can be empty for messages sent to channels
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public UserDTO FromUser { get; set; }

        /// <summary>
        /// Date the message was sent in Unix time
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public long Date { get; set; }

        /// <summary>
        /// Conversation the message belongs to
        /// </summary>
        [JsonProperty(PropertyName = "char")]
        public ChatDTO Chat { get; set; }

        /// <summary>
        /// Optional. For forwarded messages, sender of the original message
        /// </summary>
        [JsonProperty(PropertyName = "forward_from")]
        public UserDTO ForwardFromUser { get; set; }

        /// <summary>
        /// Optional. For messages forwarded from a channel, information about the original channel
        /// </summary>
        [JsonProperty(PropertyName = "forward_from_chat")]
        public ChatDTO ForwardFromChat { get; set; }

        /// <summary>
        /// Optional. For forwarded messages, date the original message was sent in Unix time
        /// </summary>
        [JsonProperty(PropertyName = "forward_date")]
        public long? ForwardDate { get; set; }

        /// <summary>
        /// Optional. For replies, the original message. 
        /// Note that the Message object in this field will not contain further
        /// reply_to_message fields even if it itself is a reply.
        /// </summary>
        [JsonProperty(PropertyName = "reply_to_message")]
        public MessageDTO ReplyToMessage { get; set; }

        /// <summary>
        /// Optional. Date the message was last edited in Unix time
        /// </summary>
        [JsonProperty(PropertyName = "edit_date")]
        public long? EditDate { get; set; }

        /// <summary>
        /// Optional. For text messages, 
        /// the actual UTF-8 text of the message, 0-4096 characters.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Optional. For text messages, special entities like usernames,
        /// URLs, bot commands, etc. that appear in the text
        /// </summary>
        // TODO 
        [JsonProperty(PropertyName = "entities")]
        public MessageEntityDTO[] Entities { get; set; }

        /// <summary>
        /// Optional. Message is an audio file, information about the file
        /// </summary>
        [JsonProperty(PropertyName = "audio")]
        public AudioDTO AudioDTO { get; set; }

        /// <summary>
        /// Optional. Message is a general file, information about the file
        /// </summary>
        [JsonProperty(PropertyName = "document")]
        public DocumentDTO Document { get; set; }

        /// <summary>
        /// Optional. Message is a game, information about the game.
        /// </summary>
        [JsonProperty(PropertyName = "game")]
        public Game Game { get; set; }

        /// <summary>
        /// Optional. Message is a photo, available sizes of the photo
        /// </summary>
        // TODO
        [JsonProperty(PropertyName = "photo")]
        public PhotoSizeDTO[] Photo { get; set; }

        /// <summary>
        /// Optional. Message is a sticker, information about the sticker
        /// </summary>
        [JsonProperty(PropertyName = "sticker")]
        public StickerDTO Sticker { get; set; }

        /// <summary>
        /// Optional. Message is a video, information about the video
        /// </summary>
        [JsonProperty(PropertyName = "video")]
        public VideoDTO Video { get; set; }

        /// <summary>
        /// Optional. Message is a voice message, information about the file
        /// </summary>
        [JsonProperty(PropertyName = "voice")]
        public VoiceDTO Voice { get; set; }

        /// <summary>
        /// Optional. Caption for the document, photo or video, 0-200 characters
        /// </summary>
        [JsonProperty(PropertyName = "caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Optional. Message is a shared contact, information about the contact
        /// </summary>
        [JsonProperty(PropertyName = "contact")]
        public ContactDTO Contact { get; set; }

        /// <summary>
        /// Optional. Message is a shared location, information about the location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public LocationDTO Location { get; set; }

        /// <summary>
        /// Optional. Message is a venue, information about the venue
        /// </summary>
        [JsonProperty(PropertyName = "venue")]
        public VenueDTO Venue { get; set; }

        /// <summary>
        /// Optional. A new member was added to the group, information about them (this member may be the bot itself)
        /// </summary>
        [JsonProperty(PropertyName = "new_chat_member")]
        public UserDTO NewChatMember { get; set; }

        /// <summary>
        /// Optional. A member was removed from the group, information about them (this member may be the bot itself)
        /// </summary>
        [JsonProperty(PropertyName = "left_chat_member")]
        public UserDTO LeftChatMember { get; set; }

        /// <summary>
        /// Optional. A chat title was changed to this value
        /// </summary>
        [JsonProperty(PropertyName = "new_chat_title")]
        public string NewChatTitle { get; set; }

        /// <summary>
        /// Optional. A chat photo was change to this value
        /// </summary>
        // TODO
        [JsonProperty(PropertyName = "new_chat_photo")]
        public PhotoSizeDTO[] NewChatPhoto { get; set; }

        /// <summary>
        /// Optional. Service message: the chat photo was deleted
        /// </summary>
        [JsonProperty(PropertyName = "delete_chat_photo")]
        public bool? DeleteChatPhoto { get; set; }

        /// <summary>
        /// Optional. Service message: the group has been created
        /// </summary>
        [JsonProperty(PropertyName = "group_chat_created")]
        public bool? GroupChatCreated { get; set; }

        /// <summary>
        /// Optional. Service message: the supergroup has been created. 
        /// This field can‘t be received in a message coming through updates,
        /// because bot can’t be a member of a supergroup when it is created.
        /// It can only be found in reply_to_message if someone replies to 
        /// a very first message in a directly created supergroup.
        /// </summary>
        [JsonProperty(PropertyName = "supergroup_chat_created")]
        public bool? SuperGroupChatCreated { get; set; }

        /// <summary>
        /// Optional. Service message: the channel has been created. 
        /// This field can‘t be received in a message coming through updates, 
        /// because bot can’t be a member of a channel when it is created. 
        /// It can only be found in reply_to_message if someone replies to 
        /// a very first message in a channel.
        /// </summary>
        [JsonProperty(PropertyName = "channel_chat_created")]
        public bool? ChannelChatCreated { get; set; }

        /// <summary>
        /// Optional. The group has been migrated to a supergroup with the 
        /// specified identifier. This number may be greater than 32 bits 
        /// and some programming languages may have difficulty/silent defects 
        /// in interpreting it. But it smaller than 52 bits, so a signed 64 bit integer 
        /// or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonProperty(PropertyName = "migrate_to_chat_id")]
        public long? MigrateToChatId { get; set; }

        /// <summary>
        /// Optional. The supergroup has been migrated from a group with the specified identifier.
        /// This number may be greater than 32 bits and some programming languages may have 
        /// difficulty/silent defects in interpreting it. But it smaller than 52 bits, 
        /// so a signed 64 bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonProperty(PropertyName = "migrate_from_chat_id")]
        public long? MigrateFromChatId { get; set; }

        /// <summary>
        /// Optional. Specified message was pinned. Note that the Message object in this field 
        /// will not contain further reply_to_message fields even if it is itself a reply.
        /// </summary>
        [JsonProperty(PropertyName = "pinned_message")]
        public MessageDTO PinnedMessage { get; set; }
    }
}
