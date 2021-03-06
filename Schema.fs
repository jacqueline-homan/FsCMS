namespace FsCms

open System
open System.Collections.Generic

module Schema = 
    type PropertyType = 
        { Name : string
          Deleted : bool }
    
    // textareas, checkboxes, etc. for node
    type Property = 
        { Type : PropertyType
          Value : string
          Deleted : bool }
    
    type AttributeType = 
        { Type : string
          Deleted : bool }
    
    // for non-property values
    type Attribute = 
        { Type : AttributeType
          Value : string
          Deleted : bool }
    
    // node can be page, blog, etc.
    type Node = 
        { Properties : Property list
          Attributes : Attribute list
          Deleted : bool }
    
    type AuditedItem = 
        | Node
        | Property
        | PropertyType
        | Attribute
        | AttributeType
    
    type AuditedAction = 
        | Create
        | Update
        | Delete
    
    type AuditLog = 
        { Item : AuditedItem
          Action : AuditedAction
          //    User: User
          TimeStamp : DateTime }
